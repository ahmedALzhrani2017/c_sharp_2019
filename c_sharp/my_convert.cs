using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    class my_convert
    {
       public static void _Parse()
        {
            string string_number = "2";
            int convert_string_to_number = int.Parse(string_number);
            Console.WriteLine(convert_string_to_number);
        }
        public static void convert_to_string()
        {
            int number = 555;
            string convert_number_to_string = Convert.ToString(number);        
            Console.WriteLine(convert_number_to_string);
        }
        public static void convert_to_number()
        {
            string string_number = "2";
            int convert_string_to_number = Convert.ToInt32(string_number);
            Console.WriteLine(convert_string_to_number);
        }        
        public static void Casting_type()
        {
            double b_1 = 201.7;
            int b_2=(int)b_1;

            object s_1 = "255";
            string s_2 = (string)s_1;
            Console.WriteLine(b_2);
            Console.WriteLine(s_2);
        }

    }
}
