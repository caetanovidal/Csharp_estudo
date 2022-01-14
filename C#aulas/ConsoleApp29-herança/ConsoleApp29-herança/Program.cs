using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp29_herança.Entities;

namespace ConsoleApp29_herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alice J", 2000.00);
            BussinesAccount bacc = new BussinesAccount(1002, "Hamburgues FC", 0.0, 2400);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BussinesAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 500.00, 0.008);

            acc.Withdraw(200);
            Console.WriteLine(acc.Balance);
            acc3.Withdraw(200);
            Console.WriteLine(acc3.Balance);

            // DOWNCASTING 

            BussinesAccount acc4 = (BussinesAccount)acc2;
            acc4.Loan(100.0);
            // erro acc2.Loan(100.00);

            // aceita mas vai dar erro, nao sao compativeis BussinesAccount acc5 = (BussinesAccount)acc3;

            if (acc3 is BussinesAccount)  // forma de fazer uma verificacao, pra n dar merda
            {
                // BussinesAccount acc5 = (BussinesAccount)acc3;
                BussinesAccount acc5 = acc3 as BussinesAccount;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");

            }

            if (acc3 is SavingsAccount)
            {
                //  SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }


            

        }
    }
}
