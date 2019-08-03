using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace my_class
{
    public class my_inheritance
    {
        public int id;
        public int name;


        public void Override_new()
        {
            Console.WriteLine("my_inheritance");
        }
    }

    public class my_inheritance2 : my_inheritance
    {
        public new void Override_new()
        {
            Console.WriteLine("my_inheritance2");
        }
    }
}