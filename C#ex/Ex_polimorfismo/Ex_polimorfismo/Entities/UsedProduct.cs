using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_polimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }
        public UsedProduct(string name, double price, DateTime data) 
            : base(name, price)
        {
            ManufactureDate = data;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2")} " +
                $"(Manufacture date: {ManufactureDate}";
        }
    }
}
