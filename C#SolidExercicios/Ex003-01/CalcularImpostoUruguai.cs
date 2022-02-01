using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003_01
{
    class CalcularImpostoUruguai : ICalcularImposto
    {
        public decimal CalcularValorImposto(decimal TotalRenda)
        {
            return TotalRenda * 0.25m;
        }
    }
}
