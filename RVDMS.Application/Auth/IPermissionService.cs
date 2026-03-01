using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Auth
{
    public interface IPermissionService
    {
        Task AssignPermissionToRoleAsync(string roleName, string permission);
        Task RemovePermissionFromRoleAsync(string roleName, string permission);
        Task<bool> RoleHasPermissionAsync(string roleName, string permission);
        Task<List<string>> GetRolePermissionsAsync(string roleName);
    }
}
