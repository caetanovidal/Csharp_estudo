using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    class PaisImpostoFactory : IVerificaPais
    {
        public IImpostos GetPais(EnumPaises pais)
        {
            IImpostos imposto;

            switch (pais)
            {
                case EnumPaises.Brasil:
                    imposto = new ImpostoBrasil();
                    break;
                case EnumPaises.Uruguai:
                    imposto = new ImpostoUruguai();
                    break;
                case EnumPaises.USA:
                    imposto = new ImpostoUSA();
                    break;
                default:
                    throw new NotImplementedException();

            }


            return imposto;
        }
    }
}
