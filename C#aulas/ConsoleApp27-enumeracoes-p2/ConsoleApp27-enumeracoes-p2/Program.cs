using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp27_enumeracoes_p2.Entities;
using ConsoleApp27_enumeracoes_p2.Entities.Enum;

namespace ConsoleApp27_enumeracoes_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string depName = Console.ReadLine();
            Department dep = new Department();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), value: Console.ReadLine());
            

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(depName);
            Worker worker = new Worker(workerName, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"Enter #{i+1} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                double hour = double.Parse(Console.ReadLine());

                HourContract contract = new HourContract(data, valueHour, hour);
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculete income (MM/YYYY): ");
            string dataWorked = Console.ReadLine();
            int month = int.Parse(dataWorked.Substring(0, 2));
            int year = int.Parse(dataWorked.Substring(3));
            double totalSalary = worker.Income(year, month);

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine($"Department: {worker.Department.Nome}");
            Console.WriteLine($"Income for {dataWorked}: {totalSalary:F2}");




        }
    }
}
