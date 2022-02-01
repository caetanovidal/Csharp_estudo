using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex004
{
    class CalcularDesconto
    {
        public IPromocao Promocao;

        public CalcularDesconto(IPromocao promo)
        {
            Promocao = promo;
        }

        public double CalcularPromo(double price)
        {
            double desconto = Promocao.Desconto(price);
            return price - desconto;
        }
    }
}
