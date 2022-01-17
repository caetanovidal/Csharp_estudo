using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp30_henranca_polimorfismo_pt2.entities;

namespace ConsoleApp30_henranca_polimorfismo_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> workers = new List<Employees>();

            for (int i =0; i < n; i++)
            {
                Console.WriteLine("Outsourced (y/n)? ");
                char yn = char.Parse(Console.ReadLine());

                Employees worker = new Employees();

                if (yn == 'y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    Console.Write("Value per hour: ");
                    double valueHour = double.Parse(Console.ReadLine());

                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine());

                    worker = new OutsourcedEmployee(name, hours, valueHour, addCharge);
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    Console.Write("Value per hour: ");
                    double valueHour = double.Parse(Console.ReadLine());

                    worker = new Employees(name, hours, valueHour);
                }

                

                workers.Add(worker);
            }

            Console.WriteLine("PAYMENTS: ");
            for (int i=0; i < n; i++)
            {
                Console.WriteLine(workers[i]);
            }

        }
    }
}
