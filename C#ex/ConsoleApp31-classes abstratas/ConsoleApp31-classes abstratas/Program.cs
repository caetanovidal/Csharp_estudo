using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp29_herança.Entities;

namespace ConsoleApp31_classes_abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BussinesAccount(1002, "Maria", 500, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500, 0.01));
            list.Add(new BussinesAccount(1005, "Anna", 500, 500));

            double sum = 0.0;

            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total = " + sum);

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine($"Updated balance for account {acc.Number}: {acc.Balance.ToString("F2")}");
            }
        }
    }
}
