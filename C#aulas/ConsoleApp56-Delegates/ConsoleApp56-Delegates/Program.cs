using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp56_Delegates.entities;

namespace ConsoleApp56_Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumVoid(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum; // referencia para a funcao

            BinaryNumericOperation op2 = new BinaryNumericOperation(CalculationService.Sum);

            double res2 = op2.Invoke(a, b);
            //Console.WriteLine(res2);

            double res = op(a, b);
            //Console.WriteLine(res);

            double result = CalculationService.Square(b);
            //Console.WriteLine(result);


            // multicast delegate

            BinaryNumVoid op4 = CalculationService.ShowSum;
            op4+= CalculationService.ShowMax;

            op4.Invoke(a, b);




        }

    }
}
