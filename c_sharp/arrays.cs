﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    class arrays
    {




        public void my_array_1()
        {
            string[] arr = new string[3];
            arr[0] = "ahmed";
            arr[1] = "hassan";
            arr[2] = "AHMED";
            Console.WriteLine(arr[2]);

            int[] array_number = new int[3];
            array_number[0] =1;
            array_number[1] =2;
            array_number[2] =3;
            Console.WriteLine(array_number[2]);

            object[] op_array = new object[3];
            op_array[0] = 'A';
            op_array[1] = "ahmed";
            op_array[2] = 20;
            Console.WriteLine(op_array[2]);

            int lenhth_array = Convert.ToInt32(Console.ReadLine());
            string[] arr_1 = new string[lenhth_array];
            Console.WriteLine(arr_1.Length);

            char[] char_array = new char[5];
            char_array[0] = 'a';
            char_array[1] = 'h';
            char_array[2] = 'm';
            char_array[3] = 'e';
            char_array[4] = 'd';
            Console.WriteLine(char_array[0].ToString() + char_array[1] + char_array[2] + char_array[3] + char_array[4]);
            string char_to_string = new string(char_array);
            Console.WriteLine(char_to_string);

            string string_to_char = "ahmed";
            char[] char_N;
            char_N = string_to_char.ToCharArray();
            Console.WriteLine(char_N);

            string[] loop_string = new string[4];
            loop_string[0] = "ahmed";
            loop_string[1] = "hassan";
            loop_string[2] = "ahmed";
            loop_string[3] = "AL Zahrani";
            for (int i = 0; i < loop_string.Length; i++)
            {
                Console.WriteLine(loop_string[i]);

            }
            foreach (var item in loop_string)
            {
                Console.WriteLine(item);
            }

        }












    }

}