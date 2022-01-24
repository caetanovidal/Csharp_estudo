using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    class ImpostoBrasil : IImpostos
    {
        public decimal BaseImposto(decimal amount)
        {
            return amount - (amount * Constantes.IMPOSTO_BR);
        }
    }
}
