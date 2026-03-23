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

            // Counties
            foreach (var county in CountySeedData.Counties)
            {
                var exists = _context.Counties.Any(c => c.Id == county.Id);
                if (!exists)
                    await _context.Counties.AddAsync(county);
            }

            // Constituencies
            foreach (var constituency in ConstituencySeedData.Constituencies)
            {
                var exists = _context.Constituencies.Any(c => c.Id == constituency.Id);
                if (!exists)
                    await _context.Constituencies.AddAsync(constituency);
            }

            // Wards
            foreach (var ward in WardSeedData.Wards)
            {
                var exists = _context.Wards.Any(w => w.Id == ward.Id);
                if (!exists)
                    await _context.Wards.AddAsync(ward);
            }

            await _context.SaveChangesAsync();

            _logger.LogInformation("Location seeding completed.");
        }

        public async Task SeedDepartmentsAndClustersAsync()
        {
            _logger.LogInformation("Starting departments and clusters seeding...");

            // Departments
            foreach (var dept in DepartmentSeedData.Departments)
            {
                var exists = _context.Departments.Any(d => d.Id == dept.Id);
                if (!exists)
                    await _context.Departments.AddAsync(dept);
            }

            // Clusters
            foreach (var cluster in ClusterSeedData.Clusters)
            {
                var exists = _context.Clusters.Any(c => c.Id == cluster.Id);
                if (!exists)
                    await _context.Clusters.AddAsync(cluster);
            }

            await _context.SaveChangesAsync();

            _logger.LogInformation("Departments and clusters seeding completed.");
        }
    }
}
