using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15_modificador_parametros
{
    class Calculator
    {
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i=0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static int Sum2(params int[] numbers)
        {
            int sum = 0;
            for (int i=0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static int Triple(int x)
        {
            return x * 3;
        }

        public static void Triple3(ref int x)
        {
            x = x * 3;
        }
        
        public static void Triple2(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
