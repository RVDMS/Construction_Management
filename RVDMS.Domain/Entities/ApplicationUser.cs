using Microsoft.AspNetCore.Identity;
using RVDMS.Domain.Constants;
using RVDMS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public required Location BaseLocation { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt {  get; set; }

        // Navigation properties
        public virtual ICollection<ProjectAssignment> ProjectAssignments { get; set; } = new List<ProjectAssignment>();
        public virtual ICollection<WeeklyReport> CreatedReports { get; set; } = new List<WeeklyReport>();

        public virtual ICollection<Project> LedProjects { get; set; } = new List<Project>();

        public virtual ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();

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
    }

}

