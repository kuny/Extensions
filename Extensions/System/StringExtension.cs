using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtension
    {
        public static string Kill(this string s, int position)
        {
            return s.Substring(0, position);
        }

        public static string subs(this string s, int startIndex, int length)
        {
            return s.Substring(startIndex, length);
        }

        /// <summary>
        /// "200102" -> DateTime(year: 2001, month: 2, day: 1)
        /// "2001/02" -> DateTime(year: 2001, month: 2, day: 1)
        /// "2001/2" -> DateTime(year: 2001, month: 2, day: 1)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static DateTime ToFirstDay(this string s)
        {
            if (s.IndexOf("/") == -1)
            {
                return (s.subs(0, 4) + "/" + s.subs(4, 2) + "/01").ToDateTime();
            }

            var a = s.Split('/');
            return new DateTime(a[0].ToI(), a[1].ToI(), 1);
        }

        /// <summary>
        /// "200101" -> DateTime(year: 2001, month: 1, day: 31)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static DateTime ToLastDay(this string s)
        {
            var firstDay = s.ToFirstDay();
            return firstDay.AddMonths(1).AddDays(-1);
        }
    }
}
