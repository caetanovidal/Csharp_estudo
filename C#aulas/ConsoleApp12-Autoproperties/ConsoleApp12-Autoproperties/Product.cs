using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_Autoproperties
{
    class Product
    {
        private string _name { get; set; }
        public double _price { get; private set; }
        public int _quant { get; private set; }

        public Product()
        {

        }

        public Product(string name, double price, int quant)
        {
            this._name = name;
            this._price = price;
            this._quant = quant;
        }

        public string Nome
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }


        public double total()
        {
            return _price * _quant;
        }

        public void add(int increase)
        {
            _quant += increase;
        }

        public void remove(int decrease)
        {
            _quant -= decrease;

        }

        public override string ToString()
        {
            return _name + ", $" + _price.ToString("F2") + ", quantidade: " + _quant +
                ", total $:" + total().ToString("F2");
        }
    }
}
