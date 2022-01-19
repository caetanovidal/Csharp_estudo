using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int Month = 3;
            DateTime InicialData = DateTime.Parse("19/01/2022");
            List<DateTime> Datas = new List<DateTime>();

            for (int i = 1; i < Month+1; i++)
            {
                
                Datas.Add(InicialData.AddMonths(i));
            }

            for (int i = 0; i < Month; i++)
            {
                Console.WriteLine(Datas[i]);
            }

            int n = 3;

            double amount = 200;

            double total = 202 * n;
            double totalFee = amount + (total * 0.02);
            Console.WriteLine(totalFee);
        }
    }
}
