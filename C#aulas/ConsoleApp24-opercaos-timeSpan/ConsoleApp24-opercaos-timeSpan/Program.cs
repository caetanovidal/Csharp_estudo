using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24_opercaos_timeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(2, 3, 4, 6, 11);

            Console.WriteLine(t4);

            Console.WriteLine("Days: " + t4.Days);

            Console.WriteLine("Total days: " + t4.TotalDays);

            Console.WriteLine("Hours: " + t4.Hours);

            Console.WriteLine("Total hours: " + t4.TotalHours);

            Console.WriteLine("Minutes: " + t4.Minutes);

            
            Console.WriteLine("Total minutes: " + t4.TotalMinutes);

            Console.WriteLine(t1.Add(t2));  // subtract, multiply(double) divide(double)...



        }
    }
}
