using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp54_ExtensionMethods.Extensions;

namespace ConsoleApp54_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 1, 20, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());


            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
            
        }
    }
}
