using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Auth
{
    public static class Permissions
    {
        public const string CreateProject = "Project.Create";
        public const string EditProject = "Project.Edit";
        public const string DeleteProject = "Project.Delete";
        public const string ViewProject = "Project.View";
        public const string SubmitReport = "Report.Submit";
        public const string ApproveReport = "Report.Approve";
        public const string ViewReport = "Report.View";
        public const string ViewFinancialData = "Dashboard.ViewFinancialData";
    }

}
