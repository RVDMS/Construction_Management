using MediatR;
using Microsoft.AspNetCore.Identity;
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
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public GetUserByIdQueryHandler(IUserRepository userRepository, UserManager<ApplicationUser> userManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
        }
        public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.UserId);
            if (user == null)
                return null;
            var roles = await _userManager.GetRolesAsync(user);

            // 3. Map to DTO
            var userDto = new UserDto
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

            return userDto;
        }
    }
}
