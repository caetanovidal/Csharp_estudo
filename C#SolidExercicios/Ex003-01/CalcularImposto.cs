using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003_01
{
    class CalcularImposto
    {
        public decimal Calcular(ICalcularImposto icalc, decimal amount)
        {
            return icalc.CalcularValorImposto(amount);
        }
    }
}
