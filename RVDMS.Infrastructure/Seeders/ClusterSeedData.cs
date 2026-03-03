using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders
{
    public static class ClusterSeedData
    {
        public static readonly List<Cluster> Clusters = new()
        {
            // ==================== HOUSING DEPARTMENT (AHP CLUSTERS) ====================
            // Based on actual regions in your data
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000001"),
                Name = "North Rift AHP Cluster",
                Code = "AHP-NR",
               
                DepartmentId = DepartmentSeedData.Departments[0].Id, // Housing Department
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000002"),
                Name = "South Rift AHP Cluster",
                Code = "AHP-SR",
                
                DepartmentId = DepartmentSeedData.Departments[0].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000003"),
                Name = "Northern AHP Cluster",
                Code = "AHP-NN",
                
                DepartmentId = DepartmentSeedData.Departments[0].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== SLUM UPGRADE DEPARTMENT ====================
            // From your data, I don't see explicit footbridge/highmast projects
            // But keeping these for future use
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000004"),
                Name = "Footbridge Projects Cluster",
                Code = "FB-01",
                DepartmentId = DepartmentSeedData.Departments[1].Id, // Slum Upgrade Department
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000005"),
                Name = "Social Housing Cluster",
                Code = "SH-01",
                DepartmentId = DepartmentSeedData.Departments[1].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000006"),
                Name = "Highmast Floodlight Cluster",
                Code = "HMF-01",
                DepartmentId = DepartmentSeedData.Departments[1].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== INSTITUTIONAL HOUSING DEPARTMENT ====================
            // Based on actual institutional projects in your data
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000007"),
                Name = "University Hostels Cluster",
                Code = "INS-UH",
               
                DepartmentId = DepartmentSeedData.Departments[2].Id, // Institutional Housing Department
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000008"),
                Name = "TVET Hostels Cluster",
                Code = "INS-TVET",
                
                DepartmentId = DepartmentSeedData.Departments[2].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000009"),
                Name = "Medical Training College Hostels",
                Code = "INS-MTC",
               
                DepartmentId = DepartmentSeedData.Departments[2].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000010"),
                Name = "Staff Housing Cluster",
                Code = "INS-STF",
                
                DepartmentId = DepartmentSeedData.Departments[2].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== URBAN DEVELOPMENT DEPARTMENT (MARKETS) ====================
            // ESP Markets - Grouped by the cluster numbers I see in your data
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000011"),
                Name = "ESP Markets Cluster 3",
                Code = "MKT-ESP-03",
                
                DepartmentId = DepartmentSeedData.Departments[3].Id, // Urban Development Department
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000012"),
                Name = "ESP Markets Cluster 4",
                Code = "MKT-ESP-04",
                
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000013"),
                Name = "ESP Markets Cluster 8",
                Code = "MKT-ESP-08",
                
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000014"),
                Name = "ESP Markets Cluster 10",
                Code = "MKT-ESP-10",
                
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000015"),
                Name = "ESP Markets Cluster 12",
                Code = "MKT-ESP-12",
                
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000016"),
                Name = "ESP Markets Cluster 19",
                Code = "MKT-ESP-19",
                
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000017"),
                Name = "ESP Markets Cluster 20",
                Code = "MKT-ESP-20",
               
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000018"),
                Name = "ESP Markets Cluster 31",
                Code = "MKT-ESP-31",
               
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000019"),
                Name = "ESP Markets Cluster 47",
                Code = "MKT-ESP-47",
               
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000020"),
                Name = "ESP Markets Cluster 66",
                Code = "MKT-ESP-66",
                
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000021"),
                Name = "ESP Markets Cluster 71",
                Code = "MKT-ESP-71",
                
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000022"),
                Name = "ESP Markets Cluster 89",
                Code = "MKT-ESP-89",
               
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000023"),
                Name = "ESP Markets Cluster 93",
                Code = "MKT-ESP-93",
                
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Modern Markets (Non-ESP)
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000024"),
                Name = "Modern Markets Cluster",
                Code = "MKT-MOD-01",
                
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000025"),
                Name = "Fish Markets Cluster",
                Code = "MKT-FSH",
                
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000026"),
                Name = "Ultra-Modern Markets Cluster",
                Code = "MKT-UM",
               
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Cluster
            {
                Id = Guid.Parse("60000000-0000-0000-0000-000000000027"),
                Name = "ESP Markets General",
                Code = "MKT-ESP-GEN",
                
                DepartmentId = DepartmentSeedData.Departments[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            }
        };
    }
}
