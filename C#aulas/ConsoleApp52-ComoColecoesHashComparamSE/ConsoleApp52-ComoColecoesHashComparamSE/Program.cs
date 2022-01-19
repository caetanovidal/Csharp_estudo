using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp52_ComoColecoesHashComparamSE.Entities;

namespace ConsoleApp52_ComoColecoesHashComparamSE
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();

            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));


            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);

            Console.WriteLine(a.Contains(prod));

            Point p = new Point(3, 4);

            Console.WriteLine(b.Contains(p));


            //Console.WriteLine(set.Contains("Maria")); // acha com GetHashCode dps confirma com Equals

            // Se getHashCode e Equals NAO estiverem implementados
            // Ira comparar de acordo com a memoria
            // Tipo referencia: compara as referencias dos objetos, pra onde estao apontado
            // Tipo valor: compara os valores dos atributos




        }
    }
}
