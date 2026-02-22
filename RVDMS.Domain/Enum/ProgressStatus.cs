using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Enum
{
    public enum ProgressStatus
    {
        Ahead = 1,
        OnTime = 2,
        Slow = 3,
        Delayed = 4,
        Completed = 5,
        NotStarted = 6
    }
}
