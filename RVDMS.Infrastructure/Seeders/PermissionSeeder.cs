using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using RVDMS.Application.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders
{
    public class PermissionSeeder
    {
        private readonly ILogger<PermissionSeeder> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;

        public PermissionSeeder(ILogger<PermissionSeeder> logger, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _roleManager = roleManager;
        }
        public async Task SeedPermissionsAsync()
        {
            _logger.LogInformation("Starting permission seeding...");

            foreach (var roleMapping in RolePermissions.RolePermissionMappings)
            {
                var roleName = roleMapping.Key;
                var permissions = roleMapping.Value;

                var role = await _roleManager.FindByNameAsync(roleName);

                if (role == null)
                {
                    _logger.LogWarning("Role '{RoleName}' not found. Skipping permission assignment.", roleName);
                    continue;
                }

                var existingClaims = await _roleManager.GetClaimsAsync(role);

                var existingPermissions = existingClaims
                    .Where(c => c.Type == "permission")
                    .Select(c => c.Value)
                    .ToList();

                foreach (var permission in permissions)
                {
                    if (!existingPermissions.Contains(permission))
                    {
                        await _roleManager.AddClaimAsync(
                            role,
                            new Claim("permission", permission));

                        _logger.LogInformation(
                            "Added permission '{Permission}' to role '{RoleName}'.",
                            permission,
                            roleName);
                    }
                }
            }

            _logger.LogInformation("Permission seeding completed.");
        }
    }
}
