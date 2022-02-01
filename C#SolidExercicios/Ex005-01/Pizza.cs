using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex005_01
{
    public abstract class Pizza
    {
        public string Sabor;

        public Pizza(string sabor)
        {
            Sabor = sabor;
        }

        public abstract int AssarPizza();

        public void DelivertPizza()
        {
            Console.WriteLine($"Entregar Pizza de {Sabor}");
        }
    }
}
