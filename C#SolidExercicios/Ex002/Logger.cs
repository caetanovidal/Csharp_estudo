using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex002
{
    class Logger : Ilogger
    {

        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
