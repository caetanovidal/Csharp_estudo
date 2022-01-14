using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20_especiais
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = "Maria";

            int a = int.Parse(Console.ReadLine());

            string day;

            switch (x) {
                case 1:
                    day = "Sunday";
                    break;

                case 2:
                    day = "Sunday";
                    break;

                case 3:
                    day = "Sunday";
                    break;

                case 4:
                    day = "Sunday";
                    break;

                case 5:
                    day = "Sunday";
                    break;

                case 6:
                    day = "Sunday";
                    break;

                case 7:
                    day = "Sunday";
                    break;

                default:
                    day = "Invalid Value";
                    break;
                
            }
            Console.WriteLine("Day: " + day);

            // Ternária

            double preco = double.Parse(Console.ReadLine());
            double desconto;

            if (preco < 20)
            {
                desconto = preco * 0.05;
            }
            else
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);

            double desconto2 = (preco < 20.0) ? preco * 0.05 : preco * 0.1;

            Console.WriteLine(desconto2);
        }
    }
}
