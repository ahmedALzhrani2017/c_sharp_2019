using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    class Statements

    {
       
        public static void my_if()
        {
            if (true)
            {
                Console.WriteLine("my_if");
            }
        }
        public static void my_if_else()
        {
            int x = 2;
            int y = 2;
           if(x==y)
            {
                Console.WriteLine("my_if_else");
            


            }                                                           
           else if (x == y)
            {
                Console.WriteLine("felse");

            }
           else
            {



            }
            
        }
        public static void my_switch()     
        {
            int n = 1;
            switch (n)
            {
                case 0:
                    Console.WriteLine("No arguments");
                    break;
                case 1:
                    Console.WriteLine("my_switch");
                    break;
                default:
                    Console.WriteLine($"{n} arguments");
                    break;
            }
        }
        public static void WhileStatement(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }
        public static void DoStatement(string[] args)
        {
            string s;
            do
            {
                s = Console.ReadLine();
                Console.WriteLine(s);
            } while (!string.IsNullOrEmpty(s));
        }
        public static void ForStatement(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
        public static void ForEachStatement(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }
        public static void BreakStatement(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                    break;
                Console.WriteLine(s);
            }
        }
        public static void ContinueStatement(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                    continue;
                Console.WriteLine(args[i]);
            }
        }
        public static void GoToStatement(string[] args)
        {
            byte i = 0;
            goto check;
        loop:
            Console.WriteLine(i++);
        check:
            goto loop;
                
        }
    }
}
