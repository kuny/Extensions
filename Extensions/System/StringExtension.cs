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
    }
}
