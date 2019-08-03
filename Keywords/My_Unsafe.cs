using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords
{
    class My_Unsafe
    {
       
        unsafe
               private static void My_Unsafe_int_address(int i){int* my_ponter = &i; Console.WriteLine((int)my_ponter);}
       
        unsafe private static void My_Unsafe_array_address(int[] i)
        {
            fixed(int* my_i =i)
            {
                int* My_ponter = my_i;
                Console.WriteLine((int)My_ponter);
            }            
        }


        public static void print_My_Unsafe_int_address()
        {
            Console.WriteLine("inter number");
            string string_number = Console.ReadLine();
            Console.WriteLine("My_Unsafe_int_address");
            int convert_string_to_number = int.Parse(string_number);
            My_Unsafe_int_address(convert_string_to_number);  
        }
        public static void print_My_Unsafe_array_address()
        {
            Console.WriteLine("My_Unsafe_array_address");
            
            My_Unsafe_array_address(new int[] { 2,3,4});
        }

    }
}
