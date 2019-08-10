using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class my_function
    {
        public void fuction_1()
        {
            Console.WriteLine("my_function");

        }
       
        public void fun_ref(ref int num)
        {
            num = 10;
            Console.WriteLine(num);
        }
        public void fun_out(out string num)
        {
            num = "ahmed";
            Console.WriteLine(num);
        }
    }
    
}

