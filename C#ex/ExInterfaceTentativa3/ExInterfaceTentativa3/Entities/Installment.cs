using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInterfaceTentativa3.Entities
{
    class Installment
    {
        #region DueDate
        public DateTime DueDate;

        
        #endregion

        #region Amount
        public double Amount;

        #endregion
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }


    }
}
