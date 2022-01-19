using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ConsoleApp49_generics_p2.Services;
using ConsoleApp49_generics_p2.Entities;

namespace ConsoleApp49_generics_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

                Product Prod = new Product(name, price);

                list.Add(Prod);

            }

            Calculation calculationService = new Calculation();

            Product max = calculationService.Max(list);
            Console.WriteLine("Most expensive:");
            Console.WriteLine(max);
        }
    }
}
