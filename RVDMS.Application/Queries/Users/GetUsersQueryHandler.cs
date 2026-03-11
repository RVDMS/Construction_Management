using MediatR;
using Microsoft.AspNetCore.Identity;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;
using RVDMS.Application.Interfaces;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.Users
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, PagedResponse<UserDto>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserRepository _userRepository;

        public GetUsersQueryHandler(UserManager<ApplicationUser> userManager, IUserRepository userRepository)
        {
            _userManager = userManager;
            _userRepository = userRepository;
        }
        public async Task<PagedResponse<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var filter = request.Filter;

            // 1. Get filtered users from repository (includes sorting and pagination)
            var users = await _userRepository.GetFilteredAsync(filter, cancellationToken);

            // 2. Map users to DTOs
            var userDtos = new List<UserDto>();
            foreach (var user in users)
            {
                // Fetch roles per user (safe for ~140 users)
                var roles = await _userManager.GetRolesAsync(user);

                var dto = new UserDto
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    PhoneNumber = user.PhoneNumber,
                    IsActive = user.IsActive,
                    Role = roles.FirstOrDefault(), // show first role
                    ProjectAssignments = user.ProjectAssignments.Select(pa => new ProjectAssignmentDto
                    {
                        ProjectName = pa.Project.Name,
                        Ward = pa.Project.Ward.Name,
                        Constituency = pa.Project.Ward.Constituency.Name,
                        County = pa.Project.Ward.Constituency.County.Name
                    }).ToList()
                };

                userDtos.Add(dto);
            }

            // 3. Get total record count for pagination
            var totalRecords = await _userRepository.CountAsync(filter, cancellationToken);

            // 4. Calculate total pages
            var totalPages = (int)Math.Ceiling((double)totalRecords / filter.PageSize);

            // 5. Return PagedResponse
            return new PagedResponse<UserDto>
            {
                Data = userDtos,
                PageNumber = filter.PageNumber,
                PageSize = filter.PageSize,
                TotalRecords = totalRecords,
                TotalPages = totalPages
            };
        }
    }
}
