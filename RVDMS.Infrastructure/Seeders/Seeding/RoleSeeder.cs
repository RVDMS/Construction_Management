using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using RVDMS.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders.Seeding
{
    public class RoleSeeder
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<RoleSeeder> _logger;

        public RoleSeeder(RoleManager<IdentityRole> roleManager, ILogger<RoleSeeder> logger)
        {
            _roleManager = roleManager;
            _logger = logger;
        }

        public async Task SeedAsync()
        {
            
            foreach (var role in UserRoles.AllRoles)
            {
                if(!await _roleManager.RoleExistsAsync(role))
                {
                    var result = await _roleManager.CreateAsync(new IdentityRole(role));

                    if (result.Succeeded)
                    {
                        _logger.LogInformation("Role {RoleName} created successfully.", role);
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            _logger.LogError("Error creating role {RoleName}: {Error}", role, error.Description);
                        }
                    }
                }
                else
                {
                    _logger.LogInformation("Role {RoleName} already exists.", role);
                }
            }
        }
    }
}
