using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Constants
{
    public static class UserRoles
    {
        public const string SuperAdmin = "SuperAdmin";
        public const string ClusterSupervisor = "CS";      // Heads several projects
        public const string RegionalLead = "RL";           // Regional Lead
        public const string ClerkOfWorks = "COW";          // One per project
        public const string CountyDirector = "CDH";        // County Director of Health? 
        public const string TechnicalLead = "TL";          // One per region/cluster

        // Helper method to get all roles
        public static string[] AllRoles => new[]
        {
            SuperAdmin,
            ClusterSupervisor,
            RegionalLead,
            ClerkOfWorks,
            CountyDirector,
            TechnicalLead
        };
        public static string[] SystemWideSingletonRoles => new[]
         {
            RegionalLead  // Only one RL in the entire system
        };

        // Region-based singleton roles (only one per region/cluster)
        public static string[] RegionBasedSingletonRoles => new[]
        {
            TechnicalLead  // Only one TL per region/cluster
        };

        // Roles that can be assigned to projects
        public static string[] ProjectAssignableRoles => new[]
        {
            ClusterSupervisor,  // Can head several projects
            ClerkOfWorks,       // One per project
            TechnicalLead       // One per region/cluster
        };

        public static string GetRoleDescription(string role)
        {
            if (!AllRoles.Contains(role))
                throw new ArgumentException("invalid role");
            return role switch
            {
                SuperAdmin => "Super Administrator",
                RegionalLead => "Regional Lead (One per system)",
                ClusterSupervisor => "Cluster Supervisor (Can head multiple projects)",
                ClerkOfWorks => "Clerk of Works (One per project)",
                CountyDirector => "County Director of Health",
                TechnicalLead => "Technical Lead (One per region/cluster)",
                _ => role
            };
        }
    }
}
