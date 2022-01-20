using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54_ExtensionMethods.Extensions
{
    static class DatetimeExtensons
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1") + " Hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1") + " Days";
            }
        }
    }
}
