using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o numero de linhas: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Informe o numero de colunas: ");
            int coluna = int.Parse(Console.ReadLine());


            int[,] mat = new int[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < coluna; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            int localizar = int.Parse(Console.ReadLine());



            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (mat[i,j] == localizar)
                    {
                        Console.WriteLine("Position: " + i + "," + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        
                        if (j < coluna-1)
                        {
                            Console.WriteLine("Right: " + mat[i, j+1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i-1,j]);
                        }
                        if (i < linha-1)
                        {
                            Console.WriteLine("Down: " + mat[i+1,j]);
                        }

                    }
                }
                
            }
        }
    }
}
