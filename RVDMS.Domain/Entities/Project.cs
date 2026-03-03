using RVDMS.Domain.Common;
using RVDMS.Domain.Constants;
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
        public string? TenderNumber { get; set; }
        public string? ProjectLeadId { get; set; }
        public virtual ApplicationUser? ProjectLead { get; set; }

        public string ContractorName {  get; set; } = string.Empty ;

        public string ConsultantName { get; set; } = string.Empty ;

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
        public virtual ICollection<ProjectAssignment> ProjectAssignments { get; set; } = new List<ProjectAssignment>();
        public virtual ICollection<WeeklyReport> WeeklyReports { get; set; } = new List<WeeklyReport>();
        

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

        public IEnumerable<Project> GetProjectsAsClerkOfWorks()
        {
            return ProjectAssignments
                .Where(pa => pa.Role == UserRoles.ClerkOfWorks && pa.RevokedAt == null)
                .Select(pa => pa.Project);
        }

        public IEnumerable<Project> GetProjectsAsTechnicalLead()
        {
            return ProjectAssignments
                .Where(pa => pa.Role == UserRoles.TechnicalLead && pa.RevokedAt == null)
                .Select(pa => pa.Project);
        }

        public IEnumerable<Project> GetProjectsAsClusterSupervisor()
        {
            return ProjectAssignments
                .Where(pa => pa.Role == UserRoles.ClusterSupervisor && pa.RevokedAt == null)
                .Select(pa => pa.Project);
        }

        public bool IsAssignedToProject(Guid projectId)
        {
            return ProjectAssignments.Any(pa =>
                pa.ProjectId == projectId &&
                pa.RevokedAt == null);
        }

        public ProjectAssignment? GetAssignmentForProject(Guid projectId)
        {
            return ProjectAssignments
                .FirstOrDefault(pa => pa.ProjectId == projectId && pa.RevokedAt == null);
        }

        public bool HasRoleOnProject(Guid projectId, string role)
        {
            return ProjectAssignments.Any(pa =>
                pa.ProjectId == projectId &&
                pa.Role == role &&
                pa.RevokedAt == null);
        }

        public IEnumerable<ProjectAssignment> GetAssignmentsByRole(string role)
        {
            return ProjectAssignments.Where(a => a.Role == role && a.RevokedAt == null);
        }


        public Location GetLocation()
        {
            return new Location(Latitude, Longitude, RadiusInMeters);
        }
    }
}
