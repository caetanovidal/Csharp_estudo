using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triangulo x: ");
            string[] vet = Console.ReadLine().Split(' ');
            double x_lado1 = double.Parse(vet[0]);
            double x_lado2 = double.Parse(vet[1]);
            double x_lado3 = double.Parse(vet[2]);

            Console.WriteLine("Entre com as medidas do triangulo y: ");
            string[] vet_y = Console.ReadLine().Split(' ');
            double y_lado1 = double.Parse(vet_y[0]);
            double y_lado2 = double.Parse(vet_y[1]);
            double y_lado3 = double.Parse(vet_y[2]);

            double p_x = (x_lado1 + x_lado2 + x_lado3) / 2;
            double p_y = (y_lado1 + y_lado2 + y_lado3) / 2;

            double area_x = Math.Sqrt(p_x * (p_x - x_lado1) * (p_x - x_lado2) * (p_x - x_lado3));

            double area_y = Math.Sqrt(p_y * (p_y - y_lado1) * (p_y - y_lado2) * (p_y - y_lado3));

            Console.WriteLine("Area de X = " + area_x.ToString("F4"));

            Console.WriteLine("Area de Y = " + area_y.ToString("F4"));

            if (area_x > area_y)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }


        }
    }
}
