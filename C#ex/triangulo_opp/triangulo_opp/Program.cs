using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo_opp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tri x = new Tri();
            Tri y = new Tri();

            Console.WriteLine("Informe os lados do triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe os lados do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Area x = " + x.Area());
            Console.WriteLine("Area y = " + y.Area());

        }
    }
}
