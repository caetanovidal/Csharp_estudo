using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_classes_abstratas.Entities;

namespace Ex_classes_abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ic = char.Parse(Console.ReadLine());
                if (ic == 'i')
                {
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Anual Income: ");
                    double renda = double.Parse(Console.ReadLine());

                    Console.WriteLine("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine());

                    Individual ind = new Individual(name, renda, healthExp);

                    list.Add(ind);
                }
                if (ic == 'c')
                {
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Anual Income: ");
                    double renda = double.Parse(Console.ReadLine());

                    Console.WriteLine("Number of employees: ");
                    int numEmp = int.Parse(Console.ReadLine());

                    Company comp = new Company(numEmp, name, renda);

                    list.Add(comp);
                }
            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer payer in list)
            {
                
                Console.WriteLine($"{payer.Name}: $ " +
                    $"{payer.TaxesPaid().ToString("F2")}");
                sum += payer.TaxesPaid();
            }

            Console.WriteLine($"Total Taxes: {sum.ToString("F2")}");

        }
    }
}
