using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders.Seeding
{
    public class UserSeeder
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<UserSeeder> _logger;

        public UserSeeder(UserManager<ApplicationUser> userManager, ILogger<UserSeeder> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public async Task SeedAsync()
        {
            _logger.LogInformation("Starting user seeding...");

            // Default password for all seeded users
            const string defaultPassword = "Default@123";

            foreach (var user in UserSeedData.Users)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if (existingUser == null)
                {
                    var result = await _userManager.CreateAsync(user, defaultPassword);

                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User {Email} created successfully.", user.Email);

                        // Assign roles to the user
                        var userRoles = UserSeedData.UserRolesMappings
                            .Where(ur => ur.UserId == user.Id)
                            .Select(ur => ur.Role)
                            .ToList();

                        foreach (var role in userRoles)
                        {
                            await _userManager.AddToRoleAsync(user, role);
                            _logger.LogInformation("Assigned role {Role} to user {Email}", role, user.Email);
                        }
                    }
                    else
                    {
                        _logger.LogError("Failed to create user {Email}. Errors: {Errors}",
                            user.Email, string.Join(", ", result.Errors.Select(e => e.Description)));
                    }
                }
                else
                {
                    _logger.LogInformation("User {Email} already exists.", user.Email);
                }
            }

            _logger.LogInformation("User seeding completed. Total users: {Count}", UserSeedData.Users.Count);
        }
    }
}
