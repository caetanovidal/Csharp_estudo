using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39_Interface.Entities
{
    class Invoce
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoce(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic Payment: {BasicPayment.ToString("F2")} \nTax:" +
                $"{Tax.ToString("F2")}\n" +
                $"Total Payment: {TotalPayment.ToString("F2")}";
        }
    }
}
