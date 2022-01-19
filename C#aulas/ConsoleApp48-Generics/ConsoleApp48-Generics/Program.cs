using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp48_Generics.entities;

namespace ConsoleApp48_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>();
            Console.WriteLine("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=0; i < n; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine();
            Console.WriteLine(printService.First());
        }
    }
}
