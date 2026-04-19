using MediatR;
using Microsoft.EntityFrameworkCore;
using RVDMS.Application.DTOs;
using RVDMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.ProjectAssignments
{
    public class GetProjectAssignmentsQueryHandler : IRequestHandler<GetProjectAssignmentsQuery, List<ProjectAssignmentDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetProjectAssignmentsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProjectAssignmentDto>> Handle(GetProjectAssignmentsQuery request, CancellationToken cancellationToken)
        {
            var assignments = await _context.ProjectAssignments
                .Include(pa => pa.Project)
                    .ThenInclude(p => p.Ward)
                        .ThenInclude(w => w.Constituency)
                            .ThenInclude(c => c.County)
                .Include(pa => pa.User)
                .Where(pa => pa.ProjectId == request.ProjectId)
                .ToListAsync(cancellationToken);

            return assignments.Select(pa => new ProjectAssignmentDto
            {
                Id = pa.Id,
                ProjectId = pa.ProjectId,
                ProjectName = pa.Project.Name,
                UserId = pa.UserId,
                UserName = $"{pa.User.FirstName} {pa.User.LastName}",
                UserEmail = pa.User.Email ?? string.Empty,
                UserPhoneNumber = pa.User.PhoneNumber,
                Role = pa.Role ?? string.Empty,
                AssignedAt = pa.AssignedAt,
                RevokedAt = pa.RevokedAt,
                Ward = pa.Project.Ward?.Name,
                Constituency = pa.Project.Ward?.Constituency?.Name,
                County = pa.Project.Ward?.Constituency?.County?.Name
            }).ToList();
        }
    }
}
