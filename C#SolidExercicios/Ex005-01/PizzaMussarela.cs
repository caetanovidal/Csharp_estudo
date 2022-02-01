using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex005_01
{
    class PizzaMussarela : Pizza
    {
        public PizzaMussarela(string sabor) : base(sabor)
        {

        }
        public override int AssarPizza()
        {
            var tempo = 20;
            Console.WriteLine($"Assando pizza de {Sabor} por {tempo} minutos");
            return tempo;
        }
    }
}
