using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Auth
{
    public class RolePermissions
    {
        public static readonly Dictionary<string, List<string>> RolePermissionMappings = new()
        {
            ["Admin"] = new List<string>
            {
                Permissions.CreateProject,
                Permissions.EditProject,
                Permissions.DeleteProject,
                Permissions.ViewProject,
                Permissions.SubmitReport,
                Permissions.ApproveReport,
                Permissions.ViewFinancialData
            },
            ["RL"] = new List<string>
            {
                Permissions.CreateProject,
                Permissions.EditProject,
                Permissions.ViewProject,
                Permissions.DeleteProject,
                Permissions.ViewFinancialData
            },
            ["COW"] = new List<string>
            {
                Permissions.ViewProject,
                Permissions.SubmitReport,
                Permissions.ViewReport
            },
            ["CDH"] = new List<string>
            {
                Permissions.ViewProject,
                Permissions.ViewReport
            },
            ["CS"] = new List<string>
            {
                Permissions.ApproveReport,
                Permissions.ViewReport
            },
            ["TL"] = new List<string>
            {
                Permissions.ViewProject,
                Permissions.ViewReport
            }
        };
    }
}
