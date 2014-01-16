using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class DateTimeExtension
    {
        public static string ToJaCal(this DateTime d)
        {
            JapaneseCalendar jaCal = new JapaneseCalendar();

            var nengo = new string[]{ "明治", "大正", "昭和", "平成" };

            var nen = nengo[jaCal.GetEra(d) - 1] + jaCal.GetYear(d) + "年";
            var tsuki = d.Month + "月";
            var hi = d.Day + "日";

            return nen + tsuki + hi;
        }

        public static DateTime ToFirstDay(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, 1);
        }

        public static DateTime ToLastDay(this DateTime d)
        {
            return d.ToFirstDay().AddMonths(1).AddDays(-1);
        }
    }
}
