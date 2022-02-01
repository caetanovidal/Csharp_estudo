using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex005_01
{
    class PizzaCalabresa : Pizza
    {
        
        public PizzaCalabresa(string nome) : base (nome)
        {
        }

        public override int AssarPizza()
        {
            var tempo = 25;
            Console.WriteLine($"Assando pizza de {Sabor}" +
                $"por {tempo} minutos");
            return tempo;
        }
    }
}
