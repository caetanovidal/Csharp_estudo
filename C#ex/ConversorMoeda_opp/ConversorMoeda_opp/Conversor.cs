using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoeda_opp
{
    class Conversor
    {
        public static double Dol_to_brl(double cotacao, int quant)
        {
            double price = cotacao * quant;
            double iof = price * 0.06;
            return price + iof;
        }
    }
}
