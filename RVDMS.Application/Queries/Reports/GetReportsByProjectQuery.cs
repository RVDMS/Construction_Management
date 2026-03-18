using MediatR;
using RVDMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.Reports
{
    public class GetReportsByProjectQuery : IRequest<List<WeeklyReportDto>>
    {
        public Guid ProjectId { get; set; }
        public bool IncludeDeleted { get; set; } = false; // Option to include soft-deleted

        public GetReportsByProjectQuery(Guid projectId, bool includeDeleted = false)
        {
            ProjectId = projectId;
            IncludeDeleted = includeDeleted;
        }

    }
}
