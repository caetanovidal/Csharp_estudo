using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_tratamento_errors.Entities;
using Ex_tratamento_errors.Entities.Exceptions;

namespace Ex_tratamento_errors
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                acc.Withdraw(withdraw);
                Console.WriteLine("New balance " + acc.Balance);
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Error in Account System: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpect Error: " + e.Message);
            }
            
        }
    }
}
