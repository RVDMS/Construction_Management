using Microsoft.AspNetCore.Identity;
using RVDMS.Application.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Security.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public PermissionService(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task AssignPermissionToRoleAsync(string roleName, string permission)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null) return;

            var existingClaim = (await _roleManager.GetClaimsAsync(role))
                .FirstOrDefault(c => c.Type == "permission" && c.Value == permission);

            if (existingClaim == null)
            {
                await _roleManager.AddClaimAsync(role, new Claim("permission", permission));
            }
        }

        public async Task<List<string>> GetRolePermissionsAsync(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null) return new List<string>();

            var claims = await _roleManager.GetClaimsAsync(role);
            return claims.Where(c => c.Type == "permission")
                        .Select(c => c.Value)
                        .ToList();
        }

        public async Task RemovePermissionFromRoleAsync(string roleName, string permission)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null) return;

            var claims = await _roleManager.GetClaimsAsync(role);
            var claimToRemove = claims.FirstOrDefault(c => c.Type == "permission" && c.Value == permission);

            if (claimToRemove != null)
            {
                await _roleManager.RemoveClaimAsync(role, claimToRemove);
            }
        }

        public async Task<bool> RoleHasPermissionAsync(string roleName, string permission)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null) return false;

            var claims = await _roleManager.GetClaimsAsync(role);
            return claims.Any(c => c.Type == "permission" && c.Value == permission);
        }
    }
}
