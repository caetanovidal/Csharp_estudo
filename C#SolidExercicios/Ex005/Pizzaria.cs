using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex005
{
    class Pizzaria
    {
        public void CriarPizza(IPizza pizza, double price, string sabor)
        {
            pizza.Price = price;
            pizza.Sabor = sabor;
        }
    }
}
