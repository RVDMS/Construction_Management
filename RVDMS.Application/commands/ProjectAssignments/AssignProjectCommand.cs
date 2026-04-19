using MediatR;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.ProjectAssignments
{
    public class AssignProjectCommand : IRequest<Result<ProjectAssignmentDto>>
    {
        public Guid ProjectId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty; // COW, TL, CS
    }
}
