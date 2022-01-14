﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22_timeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(2, 11, 21);
            Console.WriteLine(t4);

            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t5);

            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine (t6);

            TimeSpan t7 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t7);

            TimeSpan t8 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t8);

            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t9);

            TimeSpan t10 = TimeSpan.FromSeconds(10.5);
            Console.WriteLine(t10);



        }
    }
}
