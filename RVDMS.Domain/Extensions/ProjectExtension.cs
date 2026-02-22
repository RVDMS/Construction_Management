using RVDMS.Domain.Entities;
using RVDMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Extensions
{
    public static class ProjectExtension
    {
        public static string GetProgressStatusColor(this Project project)
        {
            return project.Progress.GetStatusColor();
        }
        public static bool IsAtRisk(this Project project)
        {
            return project.Progress.Status == ProgressStatus.Delayed ||
                   project.Progress.Status == ProgressStatus.Slow;
        }
        public static TimeSpan GetRemainingTime(this Project project)
        {
            return project.EndDate - DateTime.UtcNow;
        }
        public static decimal GetRemainingBudget(this Project project)
        {
            return project.ContractSum * (1 - (project.CurrentPhysicalProgress / 100));
        }
    }
}
