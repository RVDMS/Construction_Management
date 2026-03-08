using MediatR;
using RVDMS.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.Projects
{
    public record GetAllProjectsQuery(ProjectFilter Filter) : IRequest<PagedResponse<ProjectDto>>;
    
}
