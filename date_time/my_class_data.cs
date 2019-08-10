using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time
{
    class my_class_data
    {
        public static void my_function_date()

        {
            Console.WriteLine(DateTime.Now);
            DateTime my_time = new DateTime();
            my_time = DateTime.Now;
            Console.WriteLine(my_time.ToString("d"));
            Console.WriteLine(my_time.ToString("dd"));
            Console.WriteLine(my_time.ToString("ddd"));
            Console.WriteLine(my_time.ToString("dddd"));
            Console.WriteLine(my_time.ToString("M"));
            Console.WriteLine(my_time.ToString("MM"));
            Console.WriteLine(my_time.ToString("MMM"));  
            Console.WriteLine(my_time.ToString("MMMM"));  
            Console.WriteLine(my_time.ToString("y"));  
            Console.WriteLine(my_time.ToString("yy"));
            Console.WriteLine(my_time.ToString("yyy"));
            Console.WriteLine(my_time.ToString("yyyyyyyyyyy"));
            Console.WriteLine(my_time.ToString("dddd, dd MMMM yyyy HH:mm:ss"));  
            Console.WriteLine(my_time.ToString("MM/dd/yyyy HH:mm"));  
            Console.WriteLine(my_time.ToString("MM/dd/yyyy hh:mm tt"));  
            Console.WriteLine(my_time.ToString("MM/dd/yyyy H:mm"));  
            Console.WriteLine(my_time.ToString("MM/dd/yyyy h:mm tt"));  
            Console.WriteLine(my_time.ToString("MM/dd/yyyy HH:mm:ss"));  
            Console.WriteLine(my_time.ToString("MMMM dd"));  
            Console.WriteLine(my_time.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));  
            Console.WriteLine(my_time.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));  
            Console.WriteLine(my_time.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));  
            Console.WriteLine(my_time.ToString("HH:mm"));  
            Console.WriteLine(my_time.ToString("hh:mm tt"));  
            Console.WriteLine(my_time.ToString("H:mm"));  
            Console.WriteLine(my_time.ToString("h:mm tt"));  
            Console.WriteLine(my_time.ToString("HH:mm:ss"));  
            Console.WriteLine(my_time.ToString("yyyy MMMM"));  
            //string my_time_1 = DateTime.Now.ToString("d");
            //Console.WriteLine(my_time_1);
            //string my_time_2 = DateTime.Now.ToString("D");
            //Console.WriteLine(my_time_2);
        }
        public static void my_function_date_2()
        {
            DateTime dt;
            dt = Convert.ToDateTime("8/9/2019 12:10:3");
            Console.WriteLine(dt);
            Console.WriteLine(dt.ToString("dddd"));

        }
        public static void my_function_date_3()
        {
            DateTime dt= new DateTime();
            
            Console.WriteLine(dt);

        }
        public static void my_function_date_4()
        {
            
            DateTime moment = new DateTime(1999, 2, 13, 3, 57, 32, 11);
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
