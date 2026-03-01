using MediatR;
using Microsoft.AspNetCore.Identity;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;
using RVDMS.Application.Interfaces;
using RVDMS.Domain.Entities;
using RVDMS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.Users.Register
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Result<AuthResponseDto>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITokenServices _tokenServices;
        private readonly IApplicationDbContext _context;

        public RegisterUserCommandHandler(UserManager<ApplicationUser> userManager, ITokenServices tokenServices, IApplicationDbContext context)
        {
            _userManager = userManager;
            _tokenServices = tokenServices;
            _context = context;
        }
        public async Task<Result<AuthResponseDto>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var existingUser = await _userManager.FindByEmailAsync(request.Email);
                if (existingUser != null)
                {
                    return Result<AuthResponseDto>.Failure("User with this email already exists");
                }
                var user = new ApplicationUser
                {
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    UserName = request.UserName,
                    IsActive = true,
                    BaseLocation = new Location(
                        request.BaseLatitude,
                        request.BaseLongitude,
                        request.BaseRadiusInMeters
                        ),
                    CreatedAt = DateTime.UtcNow,
                    EmailConfirmed = true
                };
                var createResult = await _userManager.CreateAsync(user, request.Password);
                if (!createResult.Succeeded)
                {
                    var errors = string.Join(", ", createResult.Errors.Select(e => e.Description));
                    return Result<AuthResponseDto>.Failure($"Failed to create user: {errors}");


                }
                await _userManager.AddToRoleAsync(user, "Admin");

                //var accessToken = await _tokenServices.GenerateToken(user);
                //var refreshToken = _tokenServices.GenerateRefreshToken();

                //var refreshTokenEntity = new RefreshToken
                //{
                //    Id = Guid.NewGuid(),
                //    UserId = user.Id,
                //    Token = refreshToken,
                //    ExpiryTime = DateTime.UtcNow.AddDays(7),
                //    IsRevoked = false
                //};

                //await _context.RefreshTokens.AddAsync(refreshTokenEntity, cancellationToken);
                //await _context.SaveChangesAsync(cancellationToken);

                var authResponse = new AuthResponseDto(
                 User: new UserDto
                 {
                     Id = user.Id,
                     UserName = user.UserName,
                     Email = user.Email,
                     FirstName = user.FirstName,
                     LastName = user.LastName,
                     PhoneNumber = user.PhoneNumber,
                     IsActive = user.IsActive,
                     LastLoginAt = user.LastLoginAt
                 },
                    AccessToken: string.Empty,
                    RefreshToken: string.Empty
               );

                return Result<AuthResponseDto>.Success(authResponse);



            }
            catch (Exception ex)
            {

                return Result<AuthResponseDto>.Failure($"An error occurred during registration: {ex.Message}");
            }
        }
    }
}
