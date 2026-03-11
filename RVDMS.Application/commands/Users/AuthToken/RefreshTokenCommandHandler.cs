using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;
using RVDMS.Application.Interfaces;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.Users.AuthToken
{
    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, Result<AuthResponseDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ITokenServices _tokenServices;
        private readonly ITokenHasher _tokenHasher;
        private readonly UserManager<ApplicationUser> _userManager;

        public RefreshTokenCommandHandler(IApplicationDbContext context,
        ITokenServices tokenServices,
        ITokenHasher tokenHasher,
        UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _tokenServices = tokenServices;
            _tokenHasher = tokenHasher;
            _userManager = userManager;
        }
        public async Task<Result<AuthResponseDto>> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var hashedToken = _tokenHasher.Hash(request.RefreshToken);

            var token = await _context.RefreshTokens
                .FirstOrDefaultAsync(t => t.Token == hashedToken, cancellationToken);

            if (token == null || token.IsRevoked || token.ExpiryTime < DateTime.UtcNow)
            {
                return Result<AuthResponseDto>.Failure("Invalid refresh token");
            }

            var user = await _userManager.FindByIdAsync(token.UserId);

            if (user == null)
            {
                return Result<AuthResponseDto>.Failure("User not found");
            }

            // revoke old refresh token
            token.IsRevoked = true;

            // generate new tokens
            var newAccessToken = await _tokenServices.GenerateToken(user);
            var newRefreshToken = _tokenServices.GenerateRefreshToken();

            var hashedNewToken = _tokenHasher.Hash(newRefreshToken);

            var refreshTokenEntity = new RefreshToken
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                Token = hashedNewToken,
                ExpiryTime = DateTime.UtcNow.AddDays(7),
                IsRevoked = false
            };

            await _context.RefreshTokens.AddAsync(refreshTokenEntity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            var response = new AuthResponseDto(
                new UserDto { Id = user.Id, Email = user.Email! },
                newAccessToken,
                newRefreshToken
            );

            return Result<AuthResponseDto>.Success(response);
        }
    }
}
