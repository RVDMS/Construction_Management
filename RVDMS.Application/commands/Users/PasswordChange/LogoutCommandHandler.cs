using MediatR;
using Microsoft.EntityFrameworkCore;
using RVDMS.Application.Common;
using RVDMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.Users.PasswordChange
{
    public class LogoutCommandHandler
    : IRequestHandler<LogoutCommand, Result<string>>
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IApplicationDbContext _context;

        public LogoutCommandHandler(
            ICurrentUserService currentUserService,
            IApplicationDbContext context)
        {
            _currentUserService = currentUserService;
            _context = context;
        }

        public async Task<Result<string>> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            var userId = _currentUserService.UserId;

            if (string.IsNullOrEmpty(userId))
                return Result<string>.Failure("User not authenticated");

            var tokens = await _context.RefreshTokens
                .Where(rt => rt.UserId == userId && !rt.IsRevoked)
                .ToListAsync(cancellationToken);

            foreach (var token in tokens)
            {
                token.IsRevoked = true;
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Result<string>.Success("Logged out successfully");
        }
    }
}
