using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class my_class_random
    {
        public static void my_function_random_number()
        {
            Random rando_number = new Random();
            int number = 0;
            int max = 999;
            byte min = 1;
            number = rando_number.Next(min, max);
            Console.WriteLine(number);

        }
        public static void my_function_random_day()
        {
            Random randoum_day = new Random();
            int day= 0;
            day = randoum_day.Next(1, 8);
            DateTime dt = Convert.ToDateTime("1/1/2019");
            dt = dt.AddDays(day);
            Console.WriteLine(dt.ToString("dddd"));
        }
        public static void my_function_random_Month()
        {           
            Random randoum_month = new Random();
            int month = 0;
            month = randoum_month.Next(1,13);
            DateTime dt =Convert.ToDateTime("1/1/2019");
            dt = dt.AddMonths(month);
            Console.WriteLine(dt.ToString("MMMM"));
        }
        public static void my_function_random_year()
        {
            Random randoum_year = new Random();
            int year = 0;
            year = randoum_year.Next(0,1);
            DateTime dt = Convert.ToDateTime("1/1/2019");
            dt = dt.AddYears(year);
            Console.WriteLine(dt.ToString("yyyy"));
        }
        public static void my_function_random_day_Month_Year()
        {
            Random rnum = new Random();
            int day_name = 0;
            day_name = rnum.Next(1, 8);
            int month_name = 0;
            month_name = rnum.Next(1, 13);
            DateTime my_time = new DateTime(2019);
            my_time = DateTime.Now;
            int yers = my_time.Year;
            DateTime moment = new DateTime(yers, month_name, day_name);
            Console.WriteLine(moment.ToString("dddd/" + "MMMM/" + "yyyy"));

        }
    }
}
