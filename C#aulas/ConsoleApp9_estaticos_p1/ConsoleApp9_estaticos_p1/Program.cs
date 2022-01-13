using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_estaticos_p1
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {


            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Circunferencia: " + Calc.Circunferencia(raio)) ;

            Console.WriteLine("Volume: " + Calc.Volume(raio));

            Console.WriteLine("PI: " + Calc.Pi);

        }

        
    }
}
