using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_interface.Entities
{
    class Installment
    {
        public DateTime dueDate;
        public double amount;

        public Installment(DateTime dueDate, double amount)
        {
            this.dueDate = dueDate;
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"{dueDate.ToString(CultureInfo.InvariantCulture)} - {amount.ToString("F2")}";
        }
    }
}
