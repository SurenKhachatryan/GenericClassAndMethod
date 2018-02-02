using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassAndMethod
{

    static class MyEquals1
    {
        public static bool EqualsAllType<T>(T value, T value1)
        {
            //Boxing & UpCast
            Object obj = value;
            Object obj1 = value1;

            //UnBoxing & DownCast
            if (value is Boolean && value1 is Boolean)
            {
                return (bool)obj == (bool)obj1;
            }
            if (value is String && value1 is String)
            {
                return (string)obj == (string)obj1;
            }
            if (value is Int16 && value1 is Int16)
            {
                return (Int16)obj == (Int16)obj1;
            }
            if (value is Int32 && value1 is Int32)
            {
                return (int)obj == (int)obj1;
            }
            if (value is Int64 && value1 is Int64)
            {
                return (Int64)obj == (Int64)obj1;
            }
            if (value is UInt16 && value1 is UInt16)
            {
                return (UInt16)obj == (UInt16)obj1;
            }
            if (value is UInt32 && value1 is UInt32)
            {
                return (UInt32)obj == (UInt32)obj1;
            }
            if (value is UInt64 && value1 is UInt64)
            {
                return (UInt64)obj == (UInt64)obj1;
            }
            if (value is Double && value1 is Double)
            {
                return (double)obj == (double)obj1;
            }
            if (value is Single && value1 is Single)
            {
                return (float)obj == (float)obj1;
            }
            if (value is Char && value1 is Char)
            {
                return (char)obj == (char)obj1;
            }
            return false;
        }

        public static bool EqualsValueType<T>(T value, T value1) where T : struct
        {
            //Boxing & UpCast
            Object obj = value;
            Object obj1 = value1;

            //UnBoxing & DownCast
            if (value is Boolean && value1 is Boolean)
            {
                return (bool)obj == (bool)obj1;
            }
            if (value is Int16 && value1 is Int16)
            {
                return (Int16)obj == (Int16)obj1;
            }
            if (value is Int32 && value1 is Int32)
            {
                return (int)obj == (int)obj1;
            }
            if (value is Int64 && value1 is Int64)
            {
                return (Int64)obj == (Int64)obj1;
            }
            if (value is UInt16 && value1 is UInt16)
            {
                return (UInt16)obj == (UInt16)obj1;
            }
            if (value is UInt32 && value1 is UInt32)
            {
                return (UInt32)obj == (UInt32)obj1;
            }
            if (value is UInt64 && value1 is UInt64)
            {
                return (UInt64)obj == (UInt64)obj1;
            }
            if (value is Double && value1 is Double)
            {
                return (double)obj == (double)obj1;
            }
            if (value is Single && value1 is Single)
            {
                return (float)obj == (float)obj1;
            }
            if (value is Char && value1 is Char)
            {
                return (char)obj == (char)obj1;
            }

            return false;
        }

        public static bool EqualsRefernceType<T>(T value, T value1) where T : class
        {
            //Boxing & UpCast
            Object obj = value;
            Object obj1 = value1;

            //UnBoxing & DownCast
            if (value is String && value1 is String)
            {
                return (string)obj == (string)obj1;
            }
            return false;
        }


    }
}
