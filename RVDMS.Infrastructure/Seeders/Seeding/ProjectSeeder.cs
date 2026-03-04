using Microsoft.Extensions.Logging;
using RVDMS.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders.Seeding
{
    public class ProjectSeeder
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProjectSeeder> _logger;

        public ProjectSeeder(ApplicationDbContext context, ILogger<ProjectSeeder> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task SeedProjectsAsync()
        {
            _logger.LogInformation("Starting project seeding...");

            if (!_context.Projects.Any())
            {
                await _context.Projects.AddRangeAsync(ProjectSeedData.Projects);
                _logger.LogInformation("Seeded {Count} projects", ProjectSeedData.Projects.Count);
                await _context.SaveChangesAsync();
            }

            _logger.LogInformation("Project seeding completed.");
        }

        public async Task SeedAssignmentsAsync()
        {
            _logger.LogInformation("Starting project assignments seeding...");

            if (!_context.ProjectAssignments.Any())
            {
                await _context.ProjectAssignments.AddRangeAsync(ProjectAssignmentSeedData.ProjectAssignments);
                _logger.LogInformation("Seeded {Count} project assignments", ProjectAssignmentSeedData.ProjectAssignments.Count);
                await _context.SaveChangesAsync();
            }

            _logger.LogInformation("Project assignments seeding completed.");
        }
    }
}
