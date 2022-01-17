using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_enumeracoes.entities
{
    class OrdemItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrdemItem()
        {

        }

        public OrdemItem(int quant, double price, Product product)
        {
            Quantity = quant;
            Price = price;
            Product = product;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Price.ToString("F2")}, " +
                $"Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2")}";
        }


    }
}
