using RVDMS.Domain.Common;
using RVDMS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Entities
{
    public class WeeklyReport : BaseAuditableEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int WeekNumber { get; set; }
        public int Year { get; set; }
        public decimal ReportedProgress { get; set; }
        public string? Challenges { get; set; }
        public string? NextWeekPlan { get; set; }

        // Foreign keys
        public Guid ProjectId { get; set; }
        public string FilePath { get; set; } = string.Empty;

        // Geo-validation at time of submission
        public Location? SubmissionLocation { get; set; }
        public bool IsGeoValidated { get; set; }

        // Navigation properties
        public virtual Project Project { get; set; } = null!;
        

        public void ValidateLocation(Location projectLocation)
        {
            if (SubmissionLocation != null)
            {
                IsGeoValidated = projectLocation.IsWithinRadius(
                    SubmissionLocation.Latitude,
                    SubmissionLocation.Longitude
                );
            }
        }
    }
}
