using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularImposto imposto = new CalcularImposto();

            ICalcularImposto impostoBrasil = new CalcularImpostoBrasil();
            ICalcularImposto impostoUSA = new CalcularImpostoUSA();
            ICalcularImposto impostoUruguai = new CalcularImpostoUruguai();


            Console.WriteLine(imposto.Calcular(impostoBrasil, 1000));
            Console.WriteLine(imposto.Calcular(impostoUSA, 1000));
            Console.WriteLine(imposto.Calcular(impostoUruguai, 1000));
            

        }
    }
}
