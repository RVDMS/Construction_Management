using RVDMS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Interfaces
{
    public interface IProgressCalculator
    {
        ProjectProgress CalculateProgress(DateTime startDate, DateTime endDate, decimal physicalProgress);
        decimal CalculateTimeElapsed(DateTime startDate, DateTime endDate);
        string GetProgressStatus(decimal variance);
    }
}
