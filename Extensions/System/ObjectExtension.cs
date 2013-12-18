using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using System.ComponentModel;

namespace System
{
    public static class ObjectExtension
    {
        public static ExpandoObject ToExpando(this object anonymousObject)
        {
            IDictionary<string, object> expando = new ExpandoObject();
            foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(anonymousObject))
            {
                var obj = propertyDescriptor.GetValue(anonymousObject);
                expando.Add(propertyDescriptor.Name, obj);
            }

            return (ExpandoObject)expando;
        }

        public static string ToS(this object o)
        {
            return o.ToString();
        }

        public static int ToI(this object o)
        {
            return Convert.ToInt32(o);
        }

        public static double ToDb(this object o)
        {
            return Convert.ToDouble(o);
        }

        public static decimal ToDc(this object o)
        {
            return Convert.ToDecimal(o);
        }

        public static bool ToBool(this object o)
        {
            return Convert.ToBoolean(o);
        }

        public static double ToDouble(this object o)
        {
            return Convert.ToDouble(o);
        }

        public static int ToInt32(this object o)
        {
            return Convert.ToInt32(o);
        }

        public static decimal ToDecimal(this object o)
        {
            return Convert.ToDecimal(o);
        }

        public static DateTime ToDateTime(this object o)
        {
            return Convert.ToDateTime(o);
        }

        public static bool ToBoolean(this object o)
        {
            return Convert.ToBoolean(o);
        }

    }
}
