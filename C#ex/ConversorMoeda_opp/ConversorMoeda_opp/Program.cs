using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoeda_opp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotacao do dolar? ");
            double dolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares voce vai comprar? ");
            int quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor a ser pago em reais = " + Conversor.Dol_to_brl(dolar, quant).ToString("F2"));


        }
    }
}
