using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product x = new Product("TV", 900, 10);

            Console.WriteLine(x.Nome);
            x.Nome = "c";
            Console.WriteLine(x.Nome);
        }
    }
}
