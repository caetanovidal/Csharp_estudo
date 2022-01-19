using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_interface_seminterface.entities
{
    class Contract
    {
        public int Number;
        public DateTime DataInicio;
        public double TotalValue;
        public List<double> Installments;

        public Contract(int number, DateTime dataInicio, double totalValue)
        {
            Number = number;
            DataInicio = dataInicio;
            TotalValue = totalValue;
            Installments = new List<double>();
        }

        public void ValorMesFee(int month)
        {
            for (int i=0; i<month; i++)
            {
                double valorMes = TotalValue / month;
                double fee = (valorMes * 0.01);
                double total = valorMes + fee * (i + 1);
                double totalFee = total + (total * 0.02);
                Installments.Add(totalFee);
            }
        }
    }
}
