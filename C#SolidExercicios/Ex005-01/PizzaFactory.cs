using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex005_01
{
    public class PizzaFactory
    {
        public Pizza CriarPizza(string sabor)
        {
            Pizza pizza = null;
            if (sabor.Equals("mussarela"))
            {
                pizza = new PizzaMussarela("Mussarela");
            }
            if (sabor.Equals("calabresa"))
            {
                pizza = new PizzaCalabresa("Calabresa");
            }
            
            return pizza;
        }
    }
}
