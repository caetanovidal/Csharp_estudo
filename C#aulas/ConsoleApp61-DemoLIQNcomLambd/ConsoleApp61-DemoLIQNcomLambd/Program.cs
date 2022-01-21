using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61_DemoLIQNcomLambd
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Categoria c1 = new Categoria() { Id = 1, Name = "Tools", Tier = 2 };
            Categoria c2 = new Categoria() { Id = 2, Name = "Computers", Tier = 1 };
            Categoria c3 = new Categoria() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            var r1 = from p in products where p.Category.Tier == 1 && p.Price < 900
                     select p;
            Print("TIER 1 AND PRICE < 900", r1);

            //var r2 = products.Where(p => p.Category == c1).Select(p => p.Name);
            var r2 = from p in products where p.Category == c1 select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, Category_name = p.Category.Name});
            var r3 = from p in products
                     where p.Name[0] == 'C'
                     select new { p.Name, p.Price, Categoria = p.Category.Name};
            Print("PRODUCTS WITH C", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 = from p in products
                     where p.Category.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p;
            Print("ORDERNADO POR PRECO E NOME", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in r4 select p).Skip(2).Take(4);
            Print("ORDERNADO POR PRECO E NOME E SKIP 2 E TAKE 4 ", r5);

            var r6 = products.First();
            Console.WriteLine(r6);

            var r7 = products.Where(p => p.Price > 3000).FirstOrDefault();
            Console.WriteLine(r7);

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine(r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine(r9);

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine(r12 );

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine(r13);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine(r14);

            var r15 = products.Where(p => p.Category.Id == 2).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine(r15);

            Console.WriteLine("------------------------------------------------------");

            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Categoria, Product> group in r16)
            {
                Console.WriteLine(group.Key.Name );
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }

    }
}
