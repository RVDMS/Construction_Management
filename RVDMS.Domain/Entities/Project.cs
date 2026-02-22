using RVDMS.Domain.Common;
using RVDMS.Domain.Enum;
using RVDMS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Code { get; set; }
        public string? Description { get; set; }
        public decimal ContractSum { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus Status { get; set; }

        // Location
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double RadiusInMeters { get; set; } // Geo-fence radius

        // Progress tracking
        public decimal CurrentPhysicalProgress { get; set; }
        public DateTime? LastProgressUpdate { get; set; }
        public string? LastUpdatedById { get; set; }

        // Computed properties (not mapped to DB)
        private ProjectProgress? _progress;

        public decimal TimeElapsedPercentage
        {
            get
            {
                var totalDays = (EndDate - StartDate).TotalDays;
                var elapsedDays = (DateTime.UtcNow - StartDate).TotalDays;

                if (totalDays <= 0) return 0;
                if (elapsedDays <= 0) return 0;
                if (elapsedDays >= totalDays) return 100;

                return (decimal)((elapsedDays / totalDays) * 100);
            }
        }

        public ProjectProgress Progress =>
            _progress ??= new ProjectProgress(TimeElapsedPercentage, CurrentPhysicalProgress);

        // Foreign keys
        public Guid WardId { get; set; }
        public Guid? ClusterId { get; set; }

        // Navigation properties
        public virtual Ward Ward { get; set; } = null!;
        public virtual Cluster? Cluster { get; set; }
        public virtual ICollection<ProjectAssignment> Assignments { get; set; } = new List<ProjectAssignment>();
        public virtual ICollection<WeeklyReport> WeeklyReports { get; set; } = new List<WeeklyReport>();
        public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>();

        public void UpdateProgress(decimal physicalProgress, string userId)
        {
            if (physicalProgress < 0 || physicalProgress > 100)
                throw new ArgumentException("Progress must be between 0 and 100");

            if (physicalProgress < CurrentPhysicalProgress)
                throw new ArgumentException("Progress cannot decrease");

            CurrentPhysicalProgress = physicalProgress;
            LastProgressUpdate = DateTime.UtcNow;
            LastUpdatedById = userId;
            UpdatedAt = DateTime.UtcNow;
            UpdatedBy = userId;

            // Reset progress calculation
            _progress = null;

            // Auto-update status if completed
            if (physicalProgress >= 100)
            {
                Status = ProjectStatus.Completed;
            }
        }

        public bool IsUserAssigned(string userId)
        {
            
            return Assignments.Any(a => a.UserId == userId && a.RevokedAt == null);
        }

        public Location GetLocation()
        {
            return new Location(Latitude, Longitude, RadiusInMeters);
        }
    }
}
