using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp49_generics_p2.Entities;

namespace ConsoleApp49_generics_p2.Services
{
    class Calculation
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list cant be empty");
            }

            T max = list[0];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0) // compare retorna > 0  se for maior e < 0 se for menor
                {
                    max = list[i];
                }
            }

            return max;
        }

    }
}
