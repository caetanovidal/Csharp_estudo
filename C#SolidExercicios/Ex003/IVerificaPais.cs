using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    interface IVerificaPais
    {
        IImpostos GetPais(EnumPaises pais);
    }
}
