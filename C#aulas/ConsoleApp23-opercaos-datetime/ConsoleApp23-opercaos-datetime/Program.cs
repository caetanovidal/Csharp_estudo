using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23_opercaos_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d2 = new DateTime(2002, 3, 12, 12, 45, 21);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day " + d.Day);
            Console.WriteLine("3) DayOfweek: " + d.DayOfWeek);
            Console.WriteLine("4) Hour: " + d.Hour);
            Console.WriteLine("5) Kind: " + d.Kind);
            Console.WriteLine("6) Minute: " + d.Minute);

            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.AddHours(2));
            Console.WriteLine(d.AddMinutes(40));

            Console.WriteLine(d2.Subtract(d));




        }
    }
}
