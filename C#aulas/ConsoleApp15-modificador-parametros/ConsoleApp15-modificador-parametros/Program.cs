using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15_modificador_parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(new int[] { 2, 3, 4 });
            int s2 = Calculator.Sum(new int[] { 4, 5, 6 });

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("------------------------------------------------------");

            int s3 = Calculator.Sum2(2, 4, 5);
            int s4 = Calculator.Sum2(4, 5, 6);

            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.WriteLine("------------------------------------------------------");

            int z = Calculator.Triple(4);

            Console.WriteLine(z);

            Console.WriteLine("------------------------------------------------------");

            int a = 10;

            Calculator.Triple3(ref a);

            Console.WriteLine(a);

            Console.WriteLine("------------------------------------------------------");

            int y = 10;

            Calculator.Triple2(y, out int triple); // pega variavel y triplica e aloca a variavel no triple
            Console.WriteLine(triple);
        }
    }
}
