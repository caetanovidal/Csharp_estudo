using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace a002_Interface_desacoplandoCodigo
{
    class RegistarNoArquivo : IRegistro
    {
        private readonly string _caminhoNomArquivo;

        public RegistarNoArquivo(string path)
        {
            _caminhoNomArquivo = path;
        }

        public void RegistraInfo(string mensagem)
        {
            Log(mensagem);
        }

        private void Log(string mensagem)
        {
            using (var sw = new StreamWriter(_caminhoNomArquivo))
            {
                sw.WriteLine(mensagem);
            }
        }
    }
}
