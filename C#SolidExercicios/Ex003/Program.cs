using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            //IImpostos imposto = new ImpostoBrasil();
            IVerificaPais pais = new PaisImpostoFactory();

            CalcularImpostos calc = new CalcularImpostos(pais);

         
            Console.WriteLine("Total a pagar para receita brasil: " + calc.AplicarTributacao(1000, EnumPaises.Brasil));
 
            Console.WriteLine("Total a pagar para receita USA: " + calc.AplicarTributacao(1000, EnumPaises.USA));
            
            Console.WriteLine("Total a pagar para receita Uruguai: " + calc.AplicarTributacao(1000, EnumPaises.Uruguai));





        }
    }
}
