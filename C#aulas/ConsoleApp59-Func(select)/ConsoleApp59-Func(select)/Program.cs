using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59_Func_select_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Func<Product, string> func = NameUpper;
            //Func<Product, string> func = p => p.Name.ToUpper();

            //List<string> listaUp = list.Select(NameUpper).ToList();
            //List<string> listaUp = list.Select(func).ToList();
            List<string> listaUp = list.Select(p => p.Name.ToUpper()).ToList();

            //List<string> listaUp = list.Select(func).ToList();

            foreach (string s in listaUp)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
