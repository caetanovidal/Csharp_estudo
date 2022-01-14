﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29_herança.Entities
{
    class BussinesAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussinesAccount()
        {

        }

        public BussinesAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }

        }
    }
}
