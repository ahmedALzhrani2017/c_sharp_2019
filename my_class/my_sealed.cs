using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_class
{
   sealed class my_sealed // sealed لا احد يورث منه
    {
    }
     class my_sealed_person
    {
    }
    class my_sealed_son:my_sealed_person 
    {
    }
}