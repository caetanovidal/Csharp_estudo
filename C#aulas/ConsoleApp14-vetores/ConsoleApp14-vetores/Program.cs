using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[3];

            for (int i=0; i < vect.Length; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
            }

            double avg = vect.Sum()/vect.Length;

            Console.WriteLine("AVG = " + avg.ToString("F2"));

        }
    }
}
