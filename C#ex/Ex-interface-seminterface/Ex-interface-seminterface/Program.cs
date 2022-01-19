using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_interface_seminterface.entities;

namespace Ex_interface_seminterface
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter contract data");
            Console.WriteLine("Number: ");
            int numb = int.Parse(Console.ReadLine());

            Console.WriteLine("Date (dd/MM/yyyy): ");
            DateTime inicialDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Contract value: ");
            double totalContract = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract Contrato = new Contract(numb, inicialDate, totalContract);

            Console.WriteLine("Installments");

            Contrato.ValorMesFee(months);

            for (int i = 0; i < months; i++)
            {
                Console.WriteLine($"Quota #{i+1}:");
                Console.WriteLine(Contrato.Installments[i]);
            }
        }
    }
}
