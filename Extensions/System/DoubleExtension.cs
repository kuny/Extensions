using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.System
{
    public static class DoubleExtension
    {
        public static double Divide(this double d, double a)
        {
            return a == 0 ? 0 : d / a;
        }

        public static int PointIndex(this double d)
        {
            var s = d.ToString();
            return s.IndexOf(".");
        }

        public static double KillDecimal(this double d)
        {
            var s = d.ToS();
            s = s.Kill(d.PointIndex());
            return s.ToDb();
        }

        public static double Round(this double d, int place, RoundMode mode)
        {
            double a = (10).Pow(place);
            double[] addValues = { 0.9, 0.5, 0 };
            double d1 = (d * a + addValues[(int)mode]).KillDecimal();
            return d1.Divide(a);
        }
    }
}
