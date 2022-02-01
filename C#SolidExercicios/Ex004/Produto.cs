using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex004
{
    class Produto
    {
        public string Name;
        public double Price;

        public Produto()
        {
        }

        public Produto(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
