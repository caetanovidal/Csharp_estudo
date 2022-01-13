using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno_opp
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();

            Console.Write("Nome do aluno: ");
            x.Name = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno:");
            x.A = int.Parse(Console.ReadLine());
            x.B = int.Parse(Console.ReadLine());
            x.C = int.Parse(Console.ReadLine());

            Console.WriteLine(x.Resultado());
     

        }
    }
}
