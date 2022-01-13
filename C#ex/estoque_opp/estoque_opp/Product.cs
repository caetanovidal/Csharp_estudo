using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_opp
{
    class Product
    {
        public string name;
        public double price;
        public int quant;

        public double total()
        {
            return price * quant;
        }

        public void add(int increase)
        {
            quant += increase;
        }

        public void remove(int decrease)
        {
            quant -= decrease;

        }

        public override string ToString()
        {
            return name + ", $" + price.ToString("F2") + ", quantidade: " + quant + 
                ", total $:" + total().ToString("F2");
        }
    }
}
