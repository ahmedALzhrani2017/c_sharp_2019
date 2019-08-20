using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folder_file
{
    class my_file
    {
        public static  void my_using_Create_write_file()
        {
            using (StreamWriter sw1 = new StreamWriter("a1.txt",false,Encoding.ASCII))
            {
                sw1.WriteLine("ahmed");
                sw1.WriteLine("hassan");
                sw1.WriteLine("AHMED");
                sw1.WriteLine("ALZahrani");
            }
        }
        public static void my_using_read_file()
        {
            using (StreamReader my_read = new StreamReader("a1.txt"))
            {
                String my_all_test = my_read.ReadToEnd();
                Console.WriteLine(my_all_test);
            }
        }
        public static void my_using_read_file_line()
        {
            using (StreamReader my_read = new StreamReader("a1.txt"))
            {
                string line;
                int number_line = 1;
                do
                {
                    line = my_read.ReadLine();
                    Console.Write(number_line+":");
                    number_line++;
                    Console.WriteLine(line);
                } while (line != null);
                
                
            }
        }
        public static void my_using_delete_file()
        {
            Console.WriteLine("delete file");
            Console.Write("inter  yes  or  no:");
            string x = Console.ReadLine();
            if (x=="yes")
             {
                 File.Delete("a1.txt");
             }
        }

            
       

        }
        
}
