using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
                     //enum x {a=12,b=3,c=12,d=25 }
                     enum xxx { a , b , c , d}
    class my_enum
    {
        public static void print_my_enum()
        {
            xxx index_1;
            index_1 = xxx.a;
            Console.WriteLine(index_1);
        }
    }
}
