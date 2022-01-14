using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19_matrizes_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int[,] mat = new int[n, n];

            for (int i=0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Main diagonal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
             
            }

            int neg_num = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0 )
                    {
                        neg_num += 1;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers = " + neg_num);
        }
    }
}
