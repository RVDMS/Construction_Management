using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<DbInitializer> _logger;

        public DbInitializer(
            PermissionSeeder permissionSeeder,
            RoleSeeder roleSeeder,
            ILogger<DbInitializer> logger)
        {
            _permissionSeeder = permissionSeeder;
            _roleSeeder = roleSeeder;
            _logger = logger;
        }
        public async Task SeedAsync()
        {
           

            _logger.LogInformation("Starting database seeding...");

            await _roleSeeder.SeedAsync();
            await _permissionSeeder.SeedPermissionsAsync();

            _logger.LogInformation("Database seeding completed.");
        }
    }
}
