using Microsoft.Extensions.Logging;
using RVDMS.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders.Seeding
{
    public class LocationSeeder
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<LocationSeeder> _logger;

        public LocationSeeder(ApplicationDbContext context, ILogger<LocationSeeder> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task SeedLocationsAsync()
        {
            _logger.LogInformation("Starting location seeding...");

            // Seed Counties
            if (!_context.Counties.Any())
            {
                await _context.Counties.AddRangeAsync(CountySeedData.Counties);
                _logger.LogInformation("Seeded {Count} counties", CountySeedData.Counties.Count);
            }

            // Seed Constituencies
            if (!_context.Constituencies.Any())
            {
                await _context.Constituencies.AddRangeAsync(ConstituencySeedData.Constituencies);
                _logger.LogInformation("Seeded {Count} constituencies", ConstituencySeedData.Constituencies.Count);
            }

            // Seed Wards
            if (!_context.Wards.Any())
            {
                await _context.Wards.AddRangeAsync(WardSeedData.Wards);
                _logger.LogInformation("Seeded {Count} wards", WardSeedData.Wards.Count);
            }

            await _context.SaveChangesAsync();
            _logger.LogInformation("Location seeding completed.");
        }

        public async Task SeedDepartmentsAndClustersAsync()
        {
            _logger.LogInformation("Starting departments and clusters seeding...");

            // Seed Departments
            if (!_context.Departments.Any())
            {
                await _context.Departments.AddRangeAsync(DepartmentSeedData.Departments);
                _logger.LogInformation("Seeded {Count} departments", DepartmentSeedData.Departments.Count);
            }

            // Seed Clusters
            if (!_context.Clusters.Any())
            {
                await _context.Clusters.AddRangeAsync(ClusterSeedData.Clusters);
                _logger.LogInformation("Seeded {Count} clusters", ClusterSeedData.Clusters.Count);
            }

            await _context.SaveChangesAsync();
            _logger.LogInformation("Departments and clusters seeding completed.");
        }
    }
}
