using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_sobrecarga
{
    class Product
    {
        public string name;
        public double price;
        public int quant;

        // Reaproveitando construtores
        public Product()
        {
            quant = 0;
        }

        public Product(string name, double price) : this()
        {
            this.name = name;
            this.price = price;
        }
        
        public Product(string name, double price, int quant) : this(name, price)
        {
            this.quant = quant;
        }

        // ---------------------

        public double Total()
        {
            return price * quant;
        }

        public void Add(int increase)
        {
            quant += increase;
        }

        public void Remove(int decrease)
        {
            quant -= decrease;

        }

        public override string ToString()
        {
            return name + ", $" + price.ToString("F2") + ", quantidade: " + quant +
                ", total $:" + Total().ToString("F2");
        }
    }
}
