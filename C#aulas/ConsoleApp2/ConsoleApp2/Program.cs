using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char unicode = 'Æ';
            bool completo = false;
            char genero = 'F';
            sbyte x = 127;
            int n2 = 1000;
            int n3 = 2147483637;
            long n4 = 21478539932L;
            float n5 = 4.5f;
            double n6 = 4.6;
            string name = "Maria Alana";  /// cadeia de carqacteres unicode IMUTAVEL
            object obj1 = "Alex Brown";  // Tipo generico, aceita tudo
            object obj2 = 4.5f;

            Console.WriteLine(unicode);
            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(x);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(name);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.WriteLine("--------------------------------");

            int minv = int.MinValue;
            int max = int.MaxValue;
            sbyte minSbyte = sbyte.MinValue;
            decimal maxD = decimal.MaxValue;

            Console.WriteLine(minv);
            Console.WriteLine(max);
            Console.WriteLine(minSbyte);
            Console.WriteLine(maxD);

        }
    }
}
