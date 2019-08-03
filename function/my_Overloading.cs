using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class my_Overloading
    {

        public string Overloading_1()
        {

            return "1";
        }
        public string Overloading_1(string name)
        {

            return name;
        }
        public string Overloading_1(string name, string adderss)
        {


            return adderss + name;
        }
    }
}
