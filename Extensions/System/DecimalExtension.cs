using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public enum RoundMode
    {
        RoundUp = 0,
        RoundHalfUp = 1,
        RoundDown = 2
    }

    public static class DecimalExtension
    {
        public static decimal Divide(this decimal d, decimal a)
        {
            return a == 0m ? 0m : d / a;
        }

        public static int PointIndex(this decimal d)
        {
            var s = d.ToString();
            return s.IndexOf(".");
        }

        public static decimal KillDecimal(this decimal d)
        {
            var s = d.ToS();
            s = s.Kill(d.PointIndex());
            return s.ToDc();
        }

        public static decimal Round(this decimal d, int place, RoundMode mode)
        {
            decimal a = (10).Pow(place);
            decimal[] addValues = { 0.9m, 0.5m, 0m };
            decimal d1 = (d * a + addValues[(int)mode]).KillDecimal();
            return d1.Divide(a);
        }

        public static decimal Fix(this decimal d)
        {
            return d.Round(0, RoundMode.RoundDown);
        }
    }
}
