using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15_vetores_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for  (int i=0; i<vect.Length; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price};
            }

            double sum = 0.0;
            
            for (int i=0; i<vect.Length; i++)
            {
                sum += vect[i].Price;
            }

            Console.WriteLine("AVG price = " + (sum/n).ToString("F2"));
        }
    }
}
