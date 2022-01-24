using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a005_AplicandoSOLIDpratica
{
    interface ICalculaDescontoStatusContaFactory
    {
        ICalculaDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente status);
    }
}
