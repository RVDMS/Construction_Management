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

        private ProjectProgress(decimal timeElapsedPercentage, decimal physicalProgress)
        {
            TimeElapsedPercentage = Math.Round(timeElapsedPercentage, 2);
            PhysicalProgress = Math.Round(physicalProgress, 2);
            Status = DetermineStatus();
        }

        public static ProjectProgress Create(decimal timeElapsedPercentage, decimal physicalProgress)
        {
            if (timeElapsedPercentage < 0 || timeElapsedPercentage > 100)
                throw new ArgumentException("Time elapsed percentage must be between 0 and 100");

            if (physicalProgress < 0 || physicalProgress > 100)
                throw new ArgumentException("Physical progress must be between 0 and 100");

            return new ProjectProgress(timeElapsedPercentage, physicalProgress);
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
