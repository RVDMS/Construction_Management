using RVDMS.Domain.Common;
using RVDMS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Entities
{
    public class Photo : BaseEntity
    {
        public string FileName { get; set; } = string.Empty;
        public string UserId { get; set; } = null!;
        public string FilePath { get; set; } = string.Empty;
        public string? Caption { get; set; }
        public long FileSize { get; set; }
        public string ContentType { get; set; } = string.Empty;

        // Location where photo was taken
        public Location? CaptureLocation { get; set; }

        // Foreign keys
        public Guid ProjectId { get; set; }
        public Guid? WeeklyReportId { get; set; }

        // Navigation properties
        public virtual Project Project { get; set; } = null!;
        public virtual WeeklyReport? WeeklyReport { get; set; }
    }
}
