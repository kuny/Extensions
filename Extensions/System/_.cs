using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class _
    {
        public static List<int> Iota(int times, int start = 0)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < times; i++)
            {
                list.Add(start++);
            }

            return list;
        }

        public static T[] Array<T>(params T[] a)
            where T : IComparable
        {
            return a;
        }

        public static List<Type> List<Type>(params Type[] a)
            where Type : IComparable
        {
            List<Type> list = new List<Type>();

            for (int i = 0; i < a.Length; i++) list.Add(a[i]);

            return list;
        }

        public static Dictionary<TKey, TValue> Dictionary<TKey, TValue>(params object[] a)
            where TKey : IComparable
            where TValue : IComparable
        {
            if (a.Length % 2 != 0) return null;

            Dictionary<TKey, TValue> map = new Dictionary<TKey, TValue>();
            for (int i = 0; i < (a.Length / 2); i++)
            {
                map.Add((TKey)a[i * 2], (TValue)a[i * 2 + 1]);
            }

            return map;
        }

        public static void Range(int first, int last, Action<int> action, bool excludeEnd = true)
        {

            if (excludeEnd) for (int i = first; i <= last; i++) action(i);
            else for (int i = first; i < last; i++) action(i);
        }

        public static List<T> AnonymousList<T>(T[] array)
        {
            var list = new List<T>();

            array.Length.Times(i => list.Add(array[i]));

            return list;
        }

        public static DateTime Today()
        {
            var now = DateTime.Now;
            return new DateTime(now.Year, now.Month, now.Day);
        }
    }
}
