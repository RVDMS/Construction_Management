using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.Projects
{
    public record GetProjectByIdQuery(Guid Id) : IRequest<ProjectDto>;
    
}
