using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a005_AplicandoSOLIDpratica
{
    class ClienteComum : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal precoProduto)
        {

            return precoProduto - (precoProduto * Constantes.DESCONTO_CLIENTE_COMUM);
        }
    }
}
