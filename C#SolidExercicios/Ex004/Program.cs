using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto celular = new Produto("Celular", 1500);
            Produto perfume = new Produto("Perfume", 400);

            IPromocao maes = new PromocaoDiaMaes();
            IPromocao namorados = new PromocaoDiaNamorados();

            CalcularDesconto descontoMaes = new CalcularDesconto(maes);
            Console.WriteLine(descontoMaes.CalcularPromo(celular.Price));

            CalcularDesconto descontoNamorados = new CalcularDesconto(namorados);
            Console.WriteLine(descontoNamorados.CalcularPromo(celular.Price));

        }
    }
}
