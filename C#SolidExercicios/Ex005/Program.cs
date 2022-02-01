using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza calabresa = new PizzaCalabresa();
            IPizza mussarela = new PizzaMussarela();

            Pizzaria pizzaria = new Pizzaria();

            pizzaria.CriarPizza(calabresa, 30, "calabresa");
            pizzaria.CriarPizza(mussarela, 25, "mussarela");

            Console.WriteLine(calabresa.Sabor);
            Console.WriteLine(mussarela.Sabor);
        }
    }
}
