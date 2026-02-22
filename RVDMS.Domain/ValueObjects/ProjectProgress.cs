using RVDMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.ValueObjects
{
    public class ProjectProgress
    {
        public decimal TimeElapsedPercentage { get; private set; }
        public decimal PhysicalProgress { get; private set; }
        public decimal Variance => PhysicalProgress - TimeElapsedPercentage;
        public ProgressStatus Status { get; private set; }

        public ProjectProgress(decimal timeElapsedPercentage, decimal physicalProgress)
        {
            TimeElapsedPercentage = Math.Round(timeElapsedPercentage, 2);
            PhysicalProgress = Math.Round(physicalProgress, 2);
            Status = DetermineStatus();
        }

        private ProgressStatus DetermineStatus()
        {
            if (PhysicalProgress >= 100) return ProgressStatus.Completed;
            if (PhysicalProgress == 0) return ProgressStatus.NotStarted;
            if (Variance >= 5) return ProgressStatus.Ahead;
            if (Variance >= -5) return ProgressStatus.OnTime;
            if (Variance >= -15) return ProgressStatus.Slow;
            return ProgressStatus.Delayed;
        }

        public string GetStatusColor()
        {
            return Status switch
            {
                ProgressStatus.Ahead => "green",
                ProgressStatus.OnTime => "blue",
                ProgressStatus.Slow => "yellow",
                ProgressStatus.Delayed => "red",
                ProgressStatus.Completed => "purple",
                ProgressStatus.NotStarted => "gray",
                _ => "gray"
            };
        }
    }
}
