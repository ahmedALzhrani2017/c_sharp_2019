using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_class
{
    class my_Constructor
    {
        string name;
        string id;
        public my_Constructor()
        {
            Console.WriteLine("what is your name");
        }
        public my_Constructor(string name , string id)
        {
            this.name = name;            
            this.id = id;
        }
    public void fun_1()
        {        
            Console.WriteLine("name  " + name);
            Console.WriteLine("id   " +id);         
        }
    }
}
