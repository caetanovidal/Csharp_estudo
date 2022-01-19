using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_interface.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public const double MonthlyInterest = 0.01;
        public const double FeePercentage = 0.02;
        
        public double Interest(double amount, int month)
        {
            return amount * MonthlyInterest * month;
        }

        public double PaymentFee(double amount, int month)
        {
            return (Interest(amount, month) + amount) * FeePercentage;
        }
    }
}
