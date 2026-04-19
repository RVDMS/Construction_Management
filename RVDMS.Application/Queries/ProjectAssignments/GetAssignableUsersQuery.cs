using MediatR;
using RVDMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.ProjectAssignments
{
    public class GetAssignableUsersQuery : IRequest<List<AssignableUserDto>>
    {
        public string? Role { get; set; } // COW, TL, CS
    }
}
