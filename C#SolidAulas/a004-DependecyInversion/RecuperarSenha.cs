using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_DependecyInversion
{
    class RecuperarSenha
    {
        private IDatabaseConnection _conexaoBanco;

        public RecuperarSenha(IDatabaseConnection connection)
        {
            _conexaoBanco = connection;
        }

        // cod para 
    }
}
