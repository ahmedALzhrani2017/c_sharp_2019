using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class my_class_array
    {
        public static void my_function_array_number()
        {
            int[] array_number = new int[3];
            array_number[0] = 1;
            array_number[1] = 2;
            array_number[2] = 3;
            Console.WriteLine(array_number[2]);
        }
        public static void my_function_array_lenhth()
        {
            int lenhth_array = Convert.ToInt32(Console.ReadLine());
            string[] my_array = new string[lenhth_array];
            Console.WriteLine(my_array.Length);
        }
        public static void my_function_array_char()
        {
            char[] char_array = new char[5];
            char_array[0] = 'a';
            char_array[1] = 'h';
            char_array[2] = 'm';
            char_array[3] = 'e';
            char_array[4] = 'd';
            Console.WriteLine(char_array[0].ToString() + char_array[1] + char_array[2] + char_array[3] + char_array[4]);

        }
        public static void my_function_array_char_to_string()
        {
            char[] char_array = new char[5];
            char_array[0] = 'a';
            char_array[1] = 'h';
            char_array[2] = 'm';
            char_array[3] = 'e';
            char_array[4] = 'd';
            string char_to_string = new string(char_array);
            Console.WriteLine(char_to_string);
        }
        public static void my_function_array_string_to_char()
        {
            string my_string = "ahmed";
            char[] string_to_char= my_string.ToCharArray();       
            Console.WriteLine(string_to_char);
        }
        public static void my_function_array_string()
        {

            string[] arr = new string[3];
            arr[0] = "ahmed";
            arr[1] = "hassan";
            arr[2] = "AHMED";
            Console.WriteLine(arr[2]);

        }
        public static void my_function_array_loop_string_for()
        {
            string[] loop_string = new string[4];
            loop_string[0] = "ahmed";
            loop_string[1] = "hassan";
            loop_string[2] = "ahmed";
            loop_string[3] = "AL Zahrani";
            for (int i = 0; i < loop_string.Length; i++)
            {
                Console.WriteLine(loop_string[i]);

            }
        }
        public static void my_function_array_loop_string_foreach()
        {
            string[] loop_string = new string[4];
            loop_string[0] = "ahmed";
            loop_string[1] = "hassan";
            loop_string[2] = "ahmed";
            loop_string[3] = "AL Zahrani";
            foreach (var item in loop_string)
            {
                Console.WriteLine(item);
            }
        }
        public static void my_function_array_object ()
        {
            object[] op_array = new object[3];
            op_array[0] = 'A';
            op_array[1] = "ahmed";
            op_array[2] = 20;
            Console.WriteLine(op_array[2]);


        }

           

       
      
       
       









    }

}
