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

            foreach (var project in ProjectSeedData.Projects)
            {
                var exists = _context.Projects.Any(p => p.Id == project.Id);

                if (!exists)
                {
                    await _context.Projects.AddAsync(project);
                }
            }

            var changes = await _context.SaveChangesAsync();
            _logger.LogInformation("Added {Count} new projects", changes);

            _logger.LogInformation("Project seeding completed.");
        }
        public async Task SeedAssignmentsAsync()
        {
            _logger.LogInformation("Starting project assignments seeding...");

            foreach (var assignment in ProjectAssignmentSeedData.ProjectAssignments)
            {
                var exists = _context.ProjectAssignments.Any(pa =>
                    pa.UserId == assignment.UserId &&
                    pa.ProjectId == assignment.ProjectId
                );

                if (!exists)
                {
                    await _context.ProjectAssignments.AddAsync(assignment);
                }
            }

            var changes = await _context.SaveChangesAsync();
            _logger.LogInformation("Added {Count} new project assignments", changes);

            _logger.LogInformation("Project assignments seeding completed.");
        }
    }
}
