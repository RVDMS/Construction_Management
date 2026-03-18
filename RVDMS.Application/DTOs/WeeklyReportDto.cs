using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.DTOs
{
    public class WeeklyReportDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public bool IsGeoValidated { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedById { get; set; } = string.Empty;
        public Guid ProjectId { get; set; }
        public decimal Progress { get; set; }
        public string? CreatedByName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
