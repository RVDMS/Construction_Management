using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.Projects
{
    public class ProjectDto
    {
        // Basic Info
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? TenderNumber { get; set; }
        public string? ProjectLeadName { get; set; }
        public string? ProjectLeadId { get; set; }
        public string ContractorName { get; set; } = string.Empty;
        public string ConsultantName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal ContractSum { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } = string.Empty; // ProjectStatus enum as string

        // Location Info
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double RadiusInMeters { get; set; }
        public string County { get; set; } = string.Empty;
        public string Constituency { get; set; } = string.Empty;
        public string Ward { get; set; } = string.Empty;
        public string? Cluster { get; set; }
        public Guid? ClusterId { get; set; }

        // 🔴 PROGRESS TRACKING - CRITICAL FOR YOUR SYSTEM
        public decimal CurrentPhysicalProgress { get; set; }
        public DateTime? LastProgressUpdate { get; set; }
        public string? LastUpdatedBy { get; set; }
        public string? LastUpdatedById { get; set; }

        // 📊 COMPUTED PROGRESS PROPERTIES
        public decimal TimeElapsedPercentage { get; set; }
        public decimal Variance { get; set; } // PhysicalProgress - TimeElapsedPercentage
        public string ProgressStatus { get; set; } = string.Empty; // Ahead, OnTime, Slow, Delayed, etc.
        public string ProgressStatusColor { get; set; } = string.Empty; // For UI coloring

        // ⚠️ RISK INDICATORS
        public bool IsAtRisk { get; set; }
        public int DaysRemaining { get; set; }
        public decimal RemainingBudget { get; set; }
        public decimal EstimatedCompletionCost { get; set; }

        // 📈 TREND DATA (Optional - for charts)
        
        public int TotalAssignments { get; set; }
        public string? ClerkOfWorks { get; set; }
        public string? TechnicalLead { get; set; }
        public List<string> ClusterSupervisors { get; set; } = new();

        // 📊 WEEKLY REPORTS SUMMARY
        public int TotalWeeklyReports { get; set; }
        public DateTime? LastReportDate { get; set; }
        public bool HasOverdueReports { get; set; }
    }
}
