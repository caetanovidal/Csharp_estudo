using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a002_Interface_desacoplandoCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            var registraOcorrenciasConsole =
                new RegistraOcorrencias(new RegistrarConsole());
            registraOcorrenciasConsole.Registrar("Registro console");

            string path = @"C:\Users\Windows\estudos\C#SolidAulas\a002-Interface-desacoplandoCodigo\input.txt";

            var regArquivo = 
                new RegistraOcorrencias(new RegistarNoArquivo(path));
            regArquivo.Registrar("Registro arquivo");

            


        }
    }
}
