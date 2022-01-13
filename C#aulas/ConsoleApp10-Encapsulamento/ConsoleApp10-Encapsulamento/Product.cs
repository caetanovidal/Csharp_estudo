using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_Encapsulamento
{
    class Product
    {
        private string _name;
        private double _price;
        private int _quant;

        public Product()
        {

        }

        public Product(string name, double price, int quant)
        {
            this._name = name;
            this._price = price;
            this._quant = quant;
        }

        public string GetNome()
        {
            return _name;
        }

        public void SetNome(string name)
        {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
            
        }

        public double GetPrice()
        {
            return _price;
        }

        public double GetQuant()
        {
            return _quant;
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
