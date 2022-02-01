using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    class ImpostoUruguai : IImpostos
    {
        public decimal BaseImposto(decimal amount)
        {
            return (amount * Constantes.IMPOSTO_URUGUAI);
        }
    }
}
