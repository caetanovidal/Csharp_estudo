using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_interface.Entities;


namespace Ex_interface.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePay;

        public ContractService(IOnlinePaymentService onlinePay)
        {
            _onlinePay = onlinePay;
        }

        public void ProcessContract(Contract contrato, int month)
        {
            double basicMonth = contrato.TotalValue / month;

            for (int i =1; i<month+1; i++)
            {
                DateTime dataVencimento = contrato.Data.AddMonths(i);
                double basicFee = basicMonth + _onlinePay.Interest(basicMonth, month);
                double totalFee = basicMonth + (_onlinePay.Interest(basicMonth, month) + _onlinePay.PaymentFee(basicMonth, month));
                Installment inst = new Installment(dataVencimento, totalFee);
                contrato.AddInstalment(inst);
            }
        }


    }
}
