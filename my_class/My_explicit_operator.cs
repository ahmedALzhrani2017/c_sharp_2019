using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_class
{
    class My_explicit_operator
    {
    }
    class My_explicit_operator_person
    {
        public static explicit operator My_explicit_operator_son(My_explicit_operator_person person)
        {
            return new My_explicit_operator_son();
        }
    }
    class My_explicit_operator_son
    {

        public static explicit operator My_explicit_operator_person(My_explicit_operator_son son)
        {

            return new My_explicit_operator_person();
        }

    }
}
