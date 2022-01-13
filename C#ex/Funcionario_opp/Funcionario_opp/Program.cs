using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario_opp
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();

            Console.WriteLine("Nome: ");
            x.Name = Console.ReadLine();
            Console.WriteLine("Salario Bruto: ");
            x.SalaryBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Imposto: ");
            x.Taxes = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + x);

            Console.Write("Digite a porcentagem para aumentar o salário: ");

            x.IncreaseSalary(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + x);





        }
    }
}
