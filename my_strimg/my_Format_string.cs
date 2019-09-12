using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_strimg
{
    class my_Format_string
    {
        public static void my_function_string_format()
        {
            string id = "115";
            string name = "ahmed";
            string last_name = "al zahrani";
            Console.WriteLine("id\t{0}\nneme\t{1}\nlastnema{2}", id, name, last_name);
        }
        public static void my_function_string_format_2()
        {
            int x = 14;
            Console.WriteLine("{0:00000}", x);
            Console.WriteLine("{0:c}", x);
            Console.WriteLine("{0:c5}", x);
            Console.WriteLine("{0:f2}", x);
            Console.WriteLine("{0:x}", x);
        }

        public static void Numeric_to_tostring()           
        {
            int value = 365;
            Console.WriteLine(value.ToString("D8"));
            Console.WriteLine(value.ToString("F"));
            Console.WriteLine(value.ToString("F8"));
            long value2 = -16325901;
            // Display value using the invariant culture.
            Console.WriteLine(value2.ToString(CultureInfo.InvariantCulture));
        }
         public static void Numeric_to_tostring_Hexadecimal()
        {
            int value;
            value = 0x2045e;
            Console.WriteLine(value.ToString("x"));
            // Displays 2045e
            Console.WriteLine(value.ToString("X"));
            // Displays 2045E
            Console.WriteLine(value.ToString("X8"));
            // Displays 0002045E
            value = 123456789;
            Console.WriteLine(value.ToString("X"));
            // Displays 75BCD15
            Console.WriteLine(value.ToString("X2"));
            // Displays 75BCD15
        }
    }
}
