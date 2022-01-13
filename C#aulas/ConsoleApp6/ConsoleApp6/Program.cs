using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double x = double.Parse(Console.ReadLine());


            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine($"{0}", raiz);
                Console.WriteLine("Digite outro numero: ");
                double x = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("numero negativo!");

        }
    }
}
