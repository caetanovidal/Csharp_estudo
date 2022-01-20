using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61_DemoLIQNcomLambd
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Categoria Category { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Price.ToString("F2")
                + ", "
                + Category.Name
                + ", "
                + Category.Tier;
        }
    }
}
