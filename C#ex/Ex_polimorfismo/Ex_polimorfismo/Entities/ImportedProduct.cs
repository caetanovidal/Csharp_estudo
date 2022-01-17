﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_polimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFee) 
            : base (name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("F2")} " +
                $"$ (custom fee: {CustomFee.ToString("F2")})";
        }
    }
}
