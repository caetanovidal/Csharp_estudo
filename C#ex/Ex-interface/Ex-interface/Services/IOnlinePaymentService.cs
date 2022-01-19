using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_interface.Services
{
    interface IOnlinePaymentService
    {

        double PaymentFee(double amount, int month);
        double Interest(double amount, int month);

    }
}
