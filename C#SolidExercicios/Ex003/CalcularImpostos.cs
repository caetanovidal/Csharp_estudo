using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    class CalcularImpostos
    {
        //private readonly IImpostos _impostoPais;
        private readonly IVerificaPais _pais;
        

        public CalcularImpostos(IVerificaPais pais)
        {
            //_impostoPais = impostoPais;
            _pais = pais;
        }

        public decimal AplicarTributacao(decimal amount, 
            EnumPaises paisResidente)
        {
            decimal tributo = 0;

            tributo = _pais.GetPais(paisResidente).BaseImposto(amount);

            return tributo;
        }
    }
}
