using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp22_dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            //ticks 
            Console.WriteLine(d1.Ticks);
            DateTime d2 = new DateTime(2018, 11, 25);
            Console.WriteLine(d2);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 30);
            Console.WriteLine(d3);
            DateTime d4 = new DateTime(2019, 11, 25, 20, 30, 20, 12);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);


            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-01-20 13:05:24");
            DateTime d9 = DateTime.Parse("14/01/2022");

            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);

            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("15/01/2021 14:05:42", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
        }
    }
}
