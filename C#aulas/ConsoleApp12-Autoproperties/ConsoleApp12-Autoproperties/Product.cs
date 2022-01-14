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
            int index;
            if(BuscaValor(vet, 10, out index))
            {
                // Usa o Index para algo
            }
            else
            {
                // Não encontrado;
            }
            //return _name + ", $" + _price.ToString("F2") + ", quantidade: " + _quant +
            //    ", total $:" + total().ToString("F2");
            return string.Format("{0}, ${1:F2}, quantidade: {2:F2}, total $: {3:F2}",)
        }

        private bool BuscaValor(int[] vet, int valor, out int index)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == valor)
                {
                    index = i;
                    return true;
                }
            }
            
            index = 0;
            return false;
        }

        struct Retorno
        {
            bool Encontrado;
            int Index;
        }
    }
}
