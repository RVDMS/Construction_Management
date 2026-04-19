using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;
using RVDMS.Application.Interfaces;
using RVDMS.Domain.Constants;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.ProjectAssignments
{
    public class AssignProjectCommandHandler : IRequestHandler<AssignProjectCommand, Result<ProjectAssignmentDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICurrentUserService _currentUser;

        public AssignProjectCommandHandler(
            IApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            ICurrentUserService currentUser)
        {
            _context = context;
            _userManager = userManager;
            _currentUser = currentUser;
        }

        public async Task<Result<ProjectAssignmentDto>> Handle(AssignProjectCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // 1. Validate project exists
                var project = await _context.Projects
                    .FirstOrDefaultAsync(p => p.Id == request.ProjectId, cancellationToken);

                if (project == null)
                    return Result<ProjectAssignmentDto>.Failure("Project not found");

                // 2. Validate user exists
                var user = await _userManager.FindByIdAsync(request.UserId);
                if (user == null)
                    return Result<ProjectAssignmentDto>.Failure("User not found");

                // 3. Validate role is valid
                var validRoles = new[] { UserRoles.ClerkOfWorks, UserRoles.TechnicalLead, UserRoles.ClusterSupervisor };
                if (!validRoles.Contains(request.Role))
                    return Result<ProjectAssignmentDto>.Failure($"Invalid role. Must be one of: {string.Join(", ", validRoles)}");

                // 4. Check if user already has an active assignment for this project
                var existingAssignment = await _context.ProjectAssignments
                    .FirstOrDefaultAsync(pa => pa.ProjectId == request.ProjectId
                        && pa.UserId == request.UserId
                        && pa.RevokedAt == null, cancellationToken);

                if (existingAssignment != null)
                    return Result<ProjectAssignmentDto>.Failure($"User is already assigned to this project as {existingAssignment.Role}");

                // 5. For COW role, check if project already has an active COW
                if (request.Role == UserRoles.ClerkOfWorks)
                {
                    var existingCow = await _context.ProjectAssignments
                        .FirstOrDefaultAsync(pa => pa.ProjectId == request.ProjectId
                            && pa.Role == UserRoles.ClerkOfWorks
                            && pa.RevokedAt == null, cancellationToken);

                    if (existingCow != null)
                    {
                        // Option: Revoke existing COW automatically or return error
                        // For now, return error
                        return Result<ProjectAssignmentDto>.Failure($"Project already has an active Clerk of Works. Please revoke them first.");
                    }
                }

                // 6. Create assignment
                var assignment = new ProjectAssignment
                {
                    Id = Guid.NewGuid(),
                    ProjectId = request.ProjectId,
                    UserId = request.UserId,
                    Role = request.Role,
                    AssignedAt = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = _currentUser.UserId
                };

                await _context.ProjectAssignments.AddAsync(assignment, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                // 7. Return DTO
                return Result<ProjectAssignmentDto>.Success(new ProjectAssignmentDto
                {
                    Id = assignment.Id,
                    ProjectId = assignment.ProjectId,
                    ProjectName = project.Name,
                    UserId = assignment.UserId,
                    UserName = $"{user.FirstName} {user.LastName}",
                    UserEmail = user.Email ?? string.Empty,
                    Role = assignment.Role,
                    AssignedAt = assignment.AssignedAt,
                    Ward = project.Ward?.Name,
                    Constituency = project.Ward?.Constituency?.Name,
                    County = project.Ward?.Constituency?.County?.Name
                });
            }
            catch (Exception ex)
            {
                return Result<ProjectAssignmentDto>.Failure($"An error occurred: {ex.Message}");
            }
        }
    }
}

