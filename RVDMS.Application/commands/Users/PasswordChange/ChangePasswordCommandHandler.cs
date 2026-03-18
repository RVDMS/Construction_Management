using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RVDMS.Application.Common;
using RVDMS.Application.Interfaces;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.Users.PasswordChange
{
    public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, Result<string>>
    {
        private readonly IApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICurrentUserService _currentUserService;

        public ChangePasswordCommandHandler(IApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            ICurrentUserService currentUserService)
        {
            _context = context;
            _userManager = userManager;
            _currentUserService = currentUserService;
        }
        public async Task<Result<string>> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            // 1. Get current user
            var userId = _currentUserService.UserId;

            if (string.IsNullOrEmpty(userId))
                return Result<string>.Failure("User not authenticated");

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
                return Result<string>.Failure("User not found");

            // 2. Change password
            var result = await _userManager.ChangePasswordAsync(
                user,
                request.CurrentPassword,
                request.NewPassword
            );

            if (!result.Succeeded)
                return Result<string>.Failure(
                    string.Join(", ", result.Errors.Select(e => e.Description))
                );

            // 🔥 3. Revoke ALL refresh tokens
            var tokens = await _context.RefreshTokens
                .Where(rt => rt.UserId == user.Id && !rt.IsRevoked)
                .ToListAsync(cancellationToken);

            foreach (var token in tokens)
            {
                token.IsRevoked = true;
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Result<string>.Success("Password changed successfully. Please login again.");
        }
    }
}
