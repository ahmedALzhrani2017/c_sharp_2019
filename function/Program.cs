using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class Program

    {
        public static void f(Func<int> myfunction)
        {

            myfunction();

        }


        static void Main(string[] args)
        {
            //Console.WriteLine("----------------my_function-------------------");
            //my_Overloading fun2 = new my_Overloading();
            //Console.WriteLine(fun2.Overloading_1());
            //Console.WriteLine(fun2.Overloading_1("ahmed"));
            //Console.WriteLine(fun2.Overloading_1("ahmed", "ahmed@gmail"));
            //Console.WriteLine("*********************************************************");
            //my_function my_random = new my_function();
            //my_random.my_random();
            //Console.WriteLine("*********************************************************");
            //my_function my_ref = new my_function();
            //int x = 12;
            //Console.WriteLine(x);
            //my_ref.fun_ref(ref x);
            //Console.WriteLine("*********************************************************");
            //my_function my_out = new my_function();
            //string x2 = "xv23";
            //Console.WriteLine(x);
            //my_out.fun_out(out x2);
            //Console.WriteLine("*********************************************************");
            //my_get_set get_1 = new my_get_set();
            //get_1._ID = 20;
            //get_1._NAME = "ahmed";
            //get_1._SALARY = 2500;
            //get_1.print();
            Console.WriteLine("*********************************************************");
            //my_Parameters parameters_1 = new my_Parameters();
            //parameters_1.sum(2,3);
            Program.f(g);
                
            Console.WriteLine("*********************************************************");
            


            Console.ReadKey();


        }

       static int g()
        {
            Console.WriteLine("gggggg");
            return 0;
        }
       
    }
}
