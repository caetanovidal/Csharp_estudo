using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace ConsoleApp62_Ex_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Windows\estudos\C#aulas\ConsoleApp62-Ex-linq\Input.txt";

            StreamReader sr = File.OpenText(path);

            List<Product> lista = new List<Product>();

            while (!(sr.EndOfStream))
            {
                string[] vect = sr.ReadLine().Split(',');

                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

                lista.Add(new Product(name, price));
            }

            var avg = lista.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("AVG = " + avg.ToString("F2"));

            //var r1 = from p in lista where p.Price < avg orderby p.Name select p.Name;

            var r1 = lista.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach (string p in r1)
            {
                Console.WriteLine(p);
            }

        }
    }
}
