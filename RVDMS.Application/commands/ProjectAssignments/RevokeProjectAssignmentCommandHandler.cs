using MediatR;
using Microsoft.EntityFrameworkCore;
using RVDMS.Application.Common;
using RVDMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.ProjectAssignments
{
    public class RevokeProjectAssignmentCommandHandler : IRequestHandler<RevokeProjectAssignmentCommand, Result<bool>>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUser;

        public RevokeProjectAssignmentCommandHandler(IApplicationDbContext context, ICurrentUserService currentUser)
        {
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Result<bool>> Handle(RevokeProjectAssignmentCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var assignment = await _context.ProjectAssignments
                    .FirstOrDefaultAsync(pa => pa.Id == request.AssignmentId, cancellationToken);

                if (assignment == null)
                    return Result<bool>.Failure("Assignment not found");

                if (assignment.RevokedAt != null)
                    return Result<bool>.Failure("Assignment is already revoked");

                assignment.RevokedAt = DateTime.UtcNow;
                assignment.UpdatedAt = DateTime.UtcNow;
                assignment.UpdatedBy = _currentUser.UserId;

                await _context.SaveChangesAsync(cancellationToken);

                return Result<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return Result<bool>.Failure($"An error occurred: {ex.Message}");
            }
        }
    }
}
