using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.23553;
            string name = "Maria";

            Console.Write("Boa tarde!");
            Console.WriteLine("Bom dia");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(name);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("=============================================");

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", name, idade, saldo);

            Console.WriteLine($"{name} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            Console.WriteLine(name + " tem " + idade + " anos e tem saldo igual a " + saldo + " reais");
        }
    }
}
