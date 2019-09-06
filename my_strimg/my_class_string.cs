using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_strimg
{
    class my_class_string
    {
        
        public static void UPPER_LOWER()
        {
            string st_1 = "AAAAAAAAAAA";
            Console.WriteLine(st_1.ToLower());
            string st_2 = "bbbbbbbbbbbb";
            Console.WriteLine(st_2.ToUpper());


        }
        public static void max_length()
        {
            string inter_nema = Console.ReadLine();
            
            if(inter_nema.Length<10)
            {
                Console.WriteLine("welcom");
            }
            else
            {
                Console.WriteLine("invalid name");

            }

        }
        public static void SUB_STRING()
        {
            string x = "ahmed";
            Console.WriteLine(x.Substring(2));
            Console.WriteLine(x.Substring(0,3));

        }
        public static void SPLIT_STRING()
        {
            string x = "ahmxed";
            string[] y = x.Split('x');
            
           
            foreach (string s  in y)
            {

                   Console.WriteLine(s);
            }
           


        }
    }
    
}
