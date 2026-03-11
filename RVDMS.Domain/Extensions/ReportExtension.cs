using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Extensions
{
    public static class ReportExtension
    {
        //public static bool IsLate(this WeeklyReport weeklyReport)
        //{
        //    var expectedWeek = GetCurrentWeekNumber();
        //    return weeklyReport.WeekNumber < expectedWeek - 1;
        //}
        private static int GetCurrentWeekNumber()
        {
            var culture = CultureInfo.CurrentCulture;
            return culture.Calendar.GetWeekOfYear(DateTime.UtcNow,
                culture.DateTimeFormat.CalendarWeekRule,
                culture.DateTimeFormat.FirstDayOfWeek);
        }
    }
}
