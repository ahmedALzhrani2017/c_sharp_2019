using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    class operators
    {
//        Operator precedence and associativity
//The following list orders arithmetic operators starting from the highest precedence to the lowest:

//Postfix increment x++ and decrement x-- operators
//Prefix increment ++x and decrement --x and unary + and - operators
//Multiplicative*, /, and % operators
//Additive + and - operators


        public void Arithmetic()
        {
            int i = 3;
            Console.WriteLine("int i = 3;");
            Console.WriteLine("i=3              output:  " + i);   // output: 3
            Console.WriteLine("i++=3 >    i=4   output:  " + i++); // output: 3
            Console.WriteLine("i not=3    i=4   output:  " + i);   // output:  4
            Console.WriteLine("**************************************");
            int ii = 3;
            Console.WriteLine("int ii = 3;");
            Console.WriteLine("ii=3              output:  " + ii);   // output: 3
            Console.WriteLine("++ii=1+ii > i=4   output:  " + ++ii); // output: 4
            Console.WriteLine("ii =3             output:  " + ii); // output:  4


            Console.WriteLine(5 * 2);         // output: 10
            Console.WriteLine(0.5 * 2.5);     // output: 1.25
            Console.WriteLine(0.1m * 23.4m);  // output: 2.34

            Console.WriteLine(13 / 5);    // output: 2           
            Console.WriteLine(13 / (double)5);  // output: 2.6
            Console.WriteLine(13 / 5.0);       // output: 2.6

            Console.WriteLine(16.8f / 4.1f);   // output: 4.097561
            Console.WriteLine(16.8d / 4.1d);   // output: 4.09756097560976
            Console.WriteLine(16.8m / 4.1m);   // output: 4.0975609756097560975609756098

            Console.WriteLine(5 % 4);   // output: 1           
            Console.WriteLine(-5.2f % 2.0f); // output: -1.2
            Console.WriteLine(5.9 % 3.1);    // output: 2.8
            Console.WriteLine(5.9m % 3.1m);  // output: 2.8

            Console.WriteLine(5 + 4);       // output: 9
            Console.WriteLine(5 + 4.3);     // output: 9.3
            Console.WriteLine(5.1m + 4.2m); // output: 9.3

            Console.WriteLine(47 - 3);      // output: 44
            Console.WriteLine(5 - 4.3);     // output: 0.7
            Console.WriteLine(7.5m - 2.3m); // output: 5.2


            //x op = y
            //x = x op y

            int a1 = 5;
            a1 += 9;
            Console.WriteLine(a1);  // output: 14

            a1 -= 4;
            Console.WriteLine(a1);  // output: 10

            a1 *= 2;
            Console.WriteLine(a1);  // output: 20

            a1 /= 4;
            Console.WriteLine(a1);  // output: 5

            a1 %= 3;
            Console.WriteLine(a1);  // output: 2
        }
        public void logical()
        {

            Console.WriteLine("Logical negation operator !");
            bool passed = false;          //Logical negation operator !
            Console.WriteLine(!passed);   // output: True
            Console.WriteLine(!true);     // output: False
            //----------------------------------------------------------------------------------
            Console.WriteLine("Logical AND operator &");
            bool SecondOperand()
            {
                Console.WriteLine("Second operand is evaluated.");
                return true;
            }

            bool a = false & SecondOperand();          //Logical AND operator &
            Console.WriteLine(a);                     // False                     
            bool b = true & SecondOperand();
            Console.WriteLine(b);                      // True
            //----------------------------------------------------------------------------------
            Console.WriteLine("Logical exclusive OR operator ^");
            Console.WriteLine(true ^ true);    // output: False    Logical exclusive OR operator ^
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False
           //----------------------------------------------------------------------------------

        }
        public void Bitwise_shift()
        { }
        public void Comparison()
        {
            Console.WriteLine(7.0 < 5.1);   // output: False
            Console.WriteLine(7.0 > 5.1);   // output: True
            Console.WriteLine(7.0 <= 5.1);   // output: False
            Console.WriteLine(7.0 >= 5.1);   // output: True
            Console.WriteLine(5 == 5);       // output: True
            Console.WriteLine(5 != 5);        // output: False    
        }       
        public void access()
        { }
        public void Equality()
        { }
        public void Type_testing()
        { }
        public void Pointer()
        { }
        
       
    }
}
