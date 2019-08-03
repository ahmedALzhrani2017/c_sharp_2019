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
        public  void my_using()
        {
            using (StreamWriter sw1 = new StreamWriter("a1.txt"))
            {
                sw1.WriteLine("ahmed");
                sw1.WriteLine("hassan");
                sw1.WriteLine("AHMED");
                sw1.WriteLine("ALZahrani");
            }
        }
        public static void CreateEmptyFile(string path)
        {
            if(!File.Exists(path))
            {

                File.Create(path).Close();
            }


        }
        public static void CreateEmptyFile_group(string[] paths)
        {
            foreach (string item in paths)
            {
                CreateEmptyFile(item);
            }

        }
        public static void CreateEmptyFile_group_1()
        {
            string[] file_group = { "a", "b", "c" };
            CreateEmptyFile_group(file_group);
        }

        }
        
}
