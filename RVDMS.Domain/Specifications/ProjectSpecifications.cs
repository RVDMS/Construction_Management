using RVDMS.Domain.Entities;
using RVDMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Specifications
{
    public static class ProjectSpecifications
    {
        public static Expression<Func<Project, bool>> IsDelayed()
        {
            return p => p.Progress.Variance < -15 && p.Status == ProjectStatus.InProgress;
        }

        public static Expression<Func<Project, bool>> IsSlowProgress()
        {
            return p => p.Progress.Variance >= -15 && p.Progress.Variance < -5 && p.Status == ProjectStatus.InProgress;
        }

        public static Expression<Func<Project, bool>> IsOnTime()
        {
            return p => Math.Abs(p.Progress.Variance) <= 5 && p.Status == ProjectStatus.InProgress;
        }

        public static Expression<Func<Project, bool>> IsAhead()
        {
            return p => p.Progress.Variance > 5 && p.Status == ProjectStatus.InProgress;
        }

       
    }
}
