using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class IntExtension
    {
        public static void Times(this int i, Action<int> action)
        {
            for (int j = 0; j < i; j++)
            {
                action(j);
            }
        }

        public static int Divide(this int i, int a)
        {
            return a == 0 ? 0 : i / a;
        }

        public static int Pow(this int x, int y)
        {
            return Math.Pow(x.ToDouble(), y.ToDouble()).ToInt32();
        }
    }
}
