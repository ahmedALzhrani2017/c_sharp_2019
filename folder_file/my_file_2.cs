using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folder_file
{
    class my_file_2
    {
        public static void CreateEmptyFile(string path)
        {
            if (!File.Exists(path))
            {

                File.Create(path).Close();
            }
            else
            {
                Console.WriteLine("الملف موجود");
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
