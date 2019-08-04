using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time
{
    class my_class_data
    {
        public void my_function_date()
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
