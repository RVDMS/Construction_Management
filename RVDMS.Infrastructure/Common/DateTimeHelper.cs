using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Common
{
    public static class DateTimeHelper
    {
        public static DateTime Utc(int year, int month, int day)
            => new DateTime(year, month, day, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime Utc(int year, int month, int day, int hour, int minute, int second)
            => new DateTime(year, month, day, hour, minute, second, DateTimeKind.Utc);
    }
}
