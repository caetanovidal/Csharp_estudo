using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a002_Interface_desacoplandoCodigo
{
    class RegistrarConsole : IRegistro
    {
        public void RegistraInfo(string mensagem)
        {
            Console.WriteLine($"info: {mensagem}");
        }
    }
}
