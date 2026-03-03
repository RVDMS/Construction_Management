using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders
{
    public static class DepartmentSeedData
    {
        public static readonly List<Department> Departments = new()
        {
            new Department
            {
                Id = Guid.Parse("10000000-0000-0000-0000-000000000001"),
                Name = "Housing Department",
                Code = "HD",
                Description = "Responsible for Affordable Housing Program (AHP) including social, affordable and market rate housing units",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Department
            {
                Id = Guid.Parse("10000000-0000-0000-0000-000000000002"),
                Name = "Slum Upgrade Department",
                Code = "SUD",
                Description = "Handles ESP Markets, footbridges, highmast floodlights, social housing and market infrastructure",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Department
            {
                Id = Guid.Parse("10000000-0000-0000-0000-000000000003"),
                Name = "Institutional Housing Department",
                Code = "IHD",
                Description = "Manages institutional housing programs including student hostels, TVET hostels, and staff housing",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Department
            {
                Id = Guid.Parse("10000000-0000-0000-0000-000000000004"),
                Name = "Urban Development Department",
                Code = "UDD",
                Description = "Coordinates urban development projects including modern markets and public facilities",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            }
        };
    }
}
