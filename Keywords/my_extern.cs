using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Keywords
{
    class My_extern
    {
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);
        
        public int Print_my_extern()
        {

            string myString;
            Console.Write("Enter your message: ");
            myString = Console.ReadLine();
            return MessageBox((IntPtr)0, myString, "My Message Box", 0);

        }

    }
}
