using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    class my_variables
    {
        public static void print_variables()
        {

            Console.WriteLine("byte");
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sizeof(byte)+" byte");
            Console.WriteLine("##################################################");
            Console.WriteLine("sbyte");
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sizeof(sbyte) + " byte");
            Console.WriteLine("##################################################");
            Console.WriteLine("short");
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(sizeof(short) + " byte");
            Console.WriteLine("##################################################");
            Console.WriteLine("ushort");
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(sizeof(ushort) + " byte");
            Console.WriteLine("##################################################");
            Console.WriteLine("int");
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(sizeof(int) + " byte");
            Console.WriteLine("##################################################");
            Console.WriteLine("uint");
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(sizeof(uint) + " byte");
            Console.WriteLine("##################################################");
            Console.WriteLine("long");
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(sizeof(long) + " byte");
            Console.WriteLine("##################################################");
            Console.WriteLine("ulong");
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(sizeof(ulong) + " byte");
            Console.WriteLine("##################################################");
            Console.WriteLine("char");
            Console.WriteLine(char.MinValue);
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(sizeof(char) + " byte");
            Console.WriteLine("##################################################");
            Console.WriteLine("##################################################");
        }
    }
}
