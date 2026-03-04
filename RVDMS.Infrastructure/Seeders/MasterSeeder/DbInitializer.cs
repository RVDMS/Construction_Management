using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RVDMS.Infrastructure.Seeders.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders.MasterSeeder
{
    public class DbInitializer
    {
        private readonly PermissionSeeder _permissionSeeder;
        private readonly RoleSeeder _roleSeeder;
        private readonly LocationSeeder _locationSeeder;
        private readonly UserSeeder _userSeeder;
        private readonly ProjectSeeder _projectSeeder;
        private readonly ILogger<DbInitializer> _logger;

        public DbInitializer(
            PermissionSeeder permissionSeeder,
            RoleSeeder roleSeeder,
            LocationSeeder locationSeeder,
            UserSeeder userSeeder,
            ProjectSeeder projectSeeder,
            ILogger<DbInitializer> logger)
        {
            _permissionSeeder = permissionSeeder;
            _roleSeeder = roleSeeder;
            _locationSeeder = locationSeeder;
            _userSeeder = userSeeder;
            _projectSeeder = projectSeeder;
            _logger = logger;
        }
        public async Task SeedAsync()
        {
           

            _logger.LogInformation("Starting database seeding...");

            await _roleSeeder.SeedAsync();

            await _permissionSeeder.SeedPermissionsAsync();
            
            await _userSeeder.SeedAsync();

            
            await _locationSeeder.SeedLocationsAsync();

            
            await _locationSeeder.SeedDepartmentsAndClustersAsync();

           
            await _projectSeeder.SeedProjectsAsync();

           
            await _projectSeeder.SeedAssignmentsAsync();

            _logger.LogInformation("Database seeding completed.");
        }
    }
}
