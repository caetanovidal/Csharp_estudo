using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex004
{
    class PromocaoDiaNamorados : IPromocao
    {
        public double Desconto(double amount)
        {
            if (amount > 500)
            {
                return amount * 0.25;
            }
            return amount * 0.10;
        }
    }
}
