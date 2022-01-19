using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_interface.Entities;
using Ex_interface.Services;

namespace Ex_interface
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

            Contract contrato = new Contract(numb, inicialDate, totalContract);
            ContractService contrServ = new ContractService(new PaypalService());
            contrServ.ProcessContract(contrato, months);

            Console.WriteLine("Installments");

            for (int i=1; i<months+1; i++)
            {
                Console.WriteLine($"Quota #{i}");
                Console.WriteLine(contrato.lista[i-1]);
            }
        }
    }
}
