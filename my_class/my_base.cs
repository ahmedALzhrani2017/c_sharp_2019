using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_class
{
    class my_base
    {
        
        public my_base(string type= "name class  person welcom")
        {
            Console.WriteLine("nema \\"+type);
        }
    }
    class son_1: my_base
    {
        public son_1():base("name class  son_1  welcom")
        {
        }
    }
    class son_2: my_base
    {
        public son_2():base("name class  son_2  welcom")
        {
        }
    }
    class son_3: my_base
    {
        public son_3() : base("name class  son_3  welcom")
        {
        }
    }
}
