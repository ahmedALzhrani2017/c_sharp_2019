using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_class
{
   
        class my_base_2
        {

            public my_base_2(bool isrun=true)
            {
            if (isrun) {Console.WriteLine("nema");}
                
            }
        }

        class son_4 : my_base_2
        {
            public son_4() : base(false) 
            {
            }
        }
        class son_5 : my_base_2
        {
            public son_5():base(true) 
            {
            }
        }
        class son_6 : my_base_2
        {
            public son_6() : base(false)
        {
            }
        }
    
}
