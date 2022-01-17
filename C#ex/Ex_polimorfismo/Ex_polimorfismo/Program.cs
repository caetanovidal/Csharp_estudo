using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_polimorfismo.Entities;

namespace Ex_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products: ");

            int n = int.Parse(Console.ReadLine());

            for (int i=0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.WriteLine($"Common, used or imported (c/u/i)?");
                char type = char.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());

                    Product imp = new ImportedProduct(name, price, fee);

                    list.Add(imp);
                }
                if (type == 'c')
                {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    Product imp = new Product(name, price);

                    list.Add(imp);
                }
                if (type == 'u')
                {
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    Product imp = new UsedProduct(name, price, data);

                    list.Add(imp);
                }

                

            }

            Console.WriteLine("PRICE TAGS: ");

            foreach (Product item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
