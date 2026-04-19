using MediatR;
using RVDMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.ProjectAssignments
{
    public class GetProjectAssignmentsQuery : IRequest<List<ProjectAssignmentDto>>
    {
        public Guid ProjectId { get; set; }
    }
}
