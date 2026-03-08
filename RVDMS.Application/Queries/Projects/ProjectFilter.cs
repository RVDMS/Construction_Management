using RVDMS.Application.Common;
using RVDMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.Projects
{
    public class ProjectFilter : QueryFilter
    {
        public string? Status { get; set; }
        public Guid? CountyId { get; set; }
        public Guid? ConstituencyId { get; set; }
        public Guid? WardId { get; set; }
        public Guid? ClusterId { get; set; }
        public decimal? MinContractSum { get; set; }
        public decimal? MaxContractSum { get; set; }
        public DateTime? StartDateFrom { get; set; }
        public DateTime? StartDateTo { get; set; }
        public string? ContractorName { get; set; }
        public string? ConsultantName { get; set; }

        public ProgressStatus? ProgressStatus { get; set; } // Filter by Ahead, OnTime, Slow, Delayed, etc.
        public decimal? MinPhysicalProgress { get; set; }
        public decimal? MaxPhysicalProgress { get; set; }
        public bool? IsAtRisk { get; set; } // Filter projects that are delayed/slow
        public DateTime? LastProgressUpdateFrom { get; set; }
        public DateTime? LastProgressUpdateTo { get; set; }

        // 👥 ASSIGNMENT-BASED FILTERS
        public string? AssignedToUserId { get; set; } // Projects assigned to specific user
        public string? Role { get; set; } // Filter by role (COW, TL, CS)

        // 📅 TIMELINE FILTERS
        public bool? IsOverdue { get; set; } // Past end date
        public bool? CompletingSoon { get; set; } // Within 30 days of completion
    }
}
