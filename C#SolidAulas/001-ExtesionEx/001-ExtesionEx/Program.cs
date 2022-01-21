using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _001_ExtesionEx.Utils;

namespace _001_ExtesionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "joao";

            test = test.Titulo();

            Console.WriteLine(test);
        }
    }
}
