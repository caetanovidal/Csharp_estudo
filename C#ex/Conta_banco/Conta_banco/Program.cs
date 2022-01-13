using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o numero da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string name = Console.ReadLine();

            Banco titular = new Banco(num, name);

            Console.Write("Havera deposito inicial(s/n)? ");
            char ys = char.Parse(Console.ReadLine());
            if (ys == 's')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double init_value = double.Parse(Console.ReadLine());
                titular.Deposit(init_value);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(titular);

            Console.WriteLine("Entre um valor para deposito: ");
            double cash = double.Parse(Console.ReadLine());
            titular.Deposit(cash);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(titular);

            Console.WriteLine("Entre um valor para saque: ");
            cash = double.Parse(Console.ReadLine());
            titular.Withdrawn(cash);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(titular);

            Console.ReadLine();


        }
    }
}
