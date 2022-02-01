using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex004
{
    class PromocaoDiaMaes : IPromocao
    {
        public double Desconto(double amount)
        {
            if (amount > 200)
            {
                return amount * 0.2;
            }
            return amount * 0.15;
        }
    }
}
