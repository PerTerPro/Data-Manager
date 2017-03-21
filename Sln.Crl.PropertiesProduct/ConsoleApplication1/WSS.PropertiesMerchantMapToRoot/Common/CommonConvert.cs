using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.PropertiesMerchantMapToRoot.Common
{
    public class CommonConvert
    {
        public static Byte Obj2Byte(object obj)
        {
            if (obj == null)
                return 0;
            try
            {
                return Convert.ToByte(obj.ToString().Replace(",", string.Empty), CultureInfo.InvariantCulture);
            }
            catch
            {
                return 0;
            }
        }
        public static String Obj2String(object obj)
        {
            if (obj == null)
                return "";
            try
            {
                return obj.ToString();
            }
            catch
            {
                return "";
            }
        }
        public static int Obj2Int(object obj, int defaultValue = 0)
        {
            if (obj == null)
                return 0;
            try
            {
                return Convert.ToInt32(obj.ToString().Replace(",", string.Empty), CultureInfo.InvariantCulture);
            }
            catch
            {
                return defaultValue;
            }
        }
        public static Boolean Obj2Bool(object obj)
        {
            if (obj == null)
                return false;
            try
            {
                return Convert.ToBoolean(obj.ToString());
            }
            catch
            {
                return false;
            }
        }
        public static double Obj2Double(object value)
        {
            if (value == null || value.ToString().Trim() == "")
                return 0;
            try
            {
                return Convert.ToDouble(value, CultureInfo.InvariantCulture);
            }
            catch
            {
                return 0;
            }
        }
        public static decimal Obj2Decimal(object value)
        {
            if (value == null || value.ToString().Trim() == "")
                return 0;
            try
            {
                return Convert.ToDecimal(value, CultureInfo.InvariantCulture);
            }
            catch
            {
                return 0;
            }
        }
        public static long Obj2Int64(object obj)
        {
            try
            {
                return Convert.ToInt64(obj);
            }
            catch
            {
                return 0;
            }
        }
        public static DateTime ObjectToDataTime(object value)
        {
            DateTime dt = DateTime.MinValue;
            try
            {
                dt = Convert.ToDateTime(value);
            }
            catch
            {
                dt = DateTime.MinValue;
            }
            return dt;
        }
    }
}
