using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp
{
    public class data_types
    {
        
 
        public  string myprint_data_types()
            
        {
            Console.WriteLine("data types");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("             ---variables---");
            Console.WriteLine("Signed integral: sbyte, short, int, long");
            Console.WriteLine("Unsigned integral: byte, ushort, uint, ulong");
            Console.WriteLine("Unicode characters: char");
            Console.WriteLine("floating-point: float, double ,  decimal");
            Console.WriteLine("Boolean: bool");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("           --- Enum types----");
            Console.WriteLine(" enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat }");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("           ---Struct types----");
            Console.WriteLine("User-defined types of the form struct struct_name {...}");
            Console.WriteLine("-------------------------------------------");

            return "";
        }
        public void my_date()
        {
            Console.WriteLine(DateTime.Now);

            string my_time = DateTime.Now.ToString();
            Console.WriteLine(my_time);

            DateTime dt;
            dt = Convert.ToDateTime("1/1/1984 12:10:3");

            DateTime moment = new DateTime(1999, 1, 13, 3, 57, 32, 11);
            int year = moment.Year;          
            int month = moment.Month;
            int day = moment.Day;            
            int hour = moment.Hour;            
            int minute = moment.Minute;           
            int second = moment.Second;
            int millisecond = moment.Millisecond;
            Console.WriteLine(year);

        }
    }
}
