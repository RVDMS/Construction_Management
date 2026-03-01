using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
