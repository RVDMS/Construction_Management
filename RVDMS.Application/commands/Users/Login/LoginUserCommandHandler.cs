using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;
using RVDMS.Application.Interfaces;
using RVDMS.Domain.Constants;
using RVDMS.Domain.Entities;
using RVDMS.Domain.Interfaces;
using RVDMS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.Users.Login
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, Result<AuthResponseDto>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ITokenServices _tokenServices;
        private readonly IGeoValidationService _geoValidationService;
        private readonly IApplicationDbContext _context;
        private readonly ITokenHasher _tokenHasher;

        public LoginUserCommandHandler(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ITokenServices tokenServices,
            IGeoValidationService geoValidationService,
            IApplicationDbContext context,
            ITokenHasher tokenHasher)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenServices = tokenServices;
            _geoValidationService = geoValidationService;
            _context = context;
            _tokenHasher = tokenHasher;
        }
        public async Task<Result<AuthResponseDto>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(request.Email);
                if (user == null || !user.IsActive)
                {
                    return Result<AuthResponseDto>.Failure("Invalid login attempt");
                }

                var signInResult = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
                if (!signInResult.Succeeded)
                {
                    return Result<AuthResponseDto>.Failure("Invalid login attempt");
                }

                var currentLocation = new Location(
                       request.CurrentLatitude,
                       request.CurrentLongitude,
                       1000
                   );
                var roles = await _userManager.GetRolesAsync(user);

                // Define roles that can bypass geofence
                var exemptRoles = new[]
                {
                    UserRoles.SuperAdmin,
                    UserRoles.RegionalLead,
                    UserRoles.TechnicalLead,
                    UserRoles.ClusterSupervisor,
                    UserRoles.CountyDirector
                };

                // Check if user has any of the exempt roles
                bool isGeoFenceExempt = roles.Any(r => exemptRoles.Contains(r));
                if (!isGeoFenceExempt && !_geoValidationService.IsWithinProjectSite(user.BaseLocation, currentLocation))
                {
                    var distance = _geoValidationService.CalculateDistance(user.BaseLocation, currentLocation);

                    return Result<AuthResponseDto>.Failure(
                        $"Access denied. You must be within {user.BaseLocation.RadiusInMeters}m of your registered location to login. " +
                        $"You are currently {distance:F0}m away."
                    );
                }

                user.LastLoginAt = DateTime.UtcNow;
                var updateResult =  await _userManager.UpdateAsync(user);
                if (!updateResult.Succeeded)
                {
                    return Result<AuthResponseDto>.Failure("Failed to update lastLogin time");
                }

                // Generate new tokens
                var accessToken = await _tokenServices.GenerateToken(user);
                var refreshToken = _tokenServices.GenerateRefreshToken();
                var hashedToken = _tokenHasher.Hash(refreshToken);

                var oldTokens = await _context.RefreshTokens
                        .Where(rt => rt.UserId == user.Id && !rt.IsRevoked)
                        .ToListAsync(cancellationToken);

                foreach (var oldToken in oldTokens)
                {
                    oldToken.IsRevoked = true; // Revoke old tokens (optional)
                }

                var refreshTokenEntity = new RefreshToken
                {
                    Id = Guid.NewGuid(),
                    UserId = user.Id,
                    Token = hashedToken,
                    ExpiryTime = DateTime.UtcNow.AddDays(7),
                    IsRevoked = false
                };
                await _context.RefreshTokens.AddAsync(refreshTokenEntity, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                var authResponse = new AuthResponseDto(
                   User: new UserDto
                   {
                       Id = user.Id,
                       UserName = user.UserName!,
                       Email = user.Email!,
                       FirstName = user.FirstName,
                       LastName = user.LastName,
                       PhoneNumber = user.PhoneNumber,
                       IsActive = user.IsActive,
                       LastLoginAt = user.LastLoginAt
                   },
                      AccessToken: accessToken,
                      RefreshToken: refreshToken
                 );

                return Result<AuthResponseDto>.Success(authResponse);
            }
            catch (Exception ex)
            {

                return Result<AuthResponseDto>.Failure($"An error occurred during login: {ex.Message}");
            }
            
        }
    }
}
