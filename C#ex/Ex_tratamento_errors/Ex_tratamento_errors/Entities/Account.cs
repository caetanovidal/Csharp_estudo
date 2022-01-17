using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_tratamento_errors.Entities.Exceptions;

namespace Ex_tratamento_errors.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }


        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (balance < 0)
            {
                throw new DomainExceptions("Balance cant be smallest then zero");
            }
            if (withdrawLimit < 0)
            {
                throw new DomainExceptions("Withdraw cant be less then zero");
            }
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new DomainExceptions("Deposit ERROR: cant be less then zero");
            }
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainExceptions("Withdraw ERROR: Dont have enough money in balance");
            }
            if (amount < 0)
            {
                throw new DomainExceptions("Withdraw ERROR: cant be less then zero");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainExceptions("Withdraw ERROR: The amount exceeds withdraw limit");
            }
            Balance -= amount;
        }
    }
}
