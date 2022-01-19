using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();

            int n = 3;
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"How many students for course {Turmas.A+i}?");
                int x = int.Parse(Console.ReadLine());

                for (int j = 0; j < x; j++)
                {
                    int idAluno = int.Parse(Console.ReadLine());

                    if (i == 0)
                        a.Add(idAluno);
                    else if (i == 1)
                        b.Add(idAluno);
                    else if (i == 2)
                        c.Add(idAluno);
                }

            }

            HashSet<int> d = new HashSet<int>(a.Union(b).Union(c));

            //HashSet<int> e = new HashSet<int>(d.Union(c));
            
            Console.WriteLine(d.Count);


        }
    }
}
