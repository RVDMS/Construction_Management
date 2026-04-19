using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RVDMS.Application.DTOs;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.ProjectAssignments
{
    public class GetAssignableUsersQueryHandler : IRequestHandler<GetAssignableUsersQuery, List<AssignableUserDto>>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public GetAssignableUsersQueryHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<List<AssignableUserDto>> Handle(GetAssignableUsersQuery request, CancellationToken cancellationToken)
        {
            IQueryable<ApplicationUser> query = _userManager.Users;

            if (!string.IsNullOrEmpty(request.Role))
            {
                var usersInRole = await _userManager.GetUsersInRoleAsync(request.Role);
                var userIds = usersInRole.Select(u => u.Id);
                query = query.Where(u => userIds.Contains(u.Id));
            }

            var users = await query.ToListAsync(cancellationToken);

            var result = new List<AssignableUserDto>();
            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                result.Add(new AssignableUserDto
                {
                    Id = user.Id,
                    Name = $"{user.FirstName} {user.LastName}",
                    Email = user.Email ?? string.Empty,
                    Role = roles.FirstOrDefault() ?? string.Empty
                });
            }

            return result;
        }
    }
}
