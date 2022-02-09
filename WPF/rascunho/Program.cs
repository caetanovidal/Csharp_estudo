using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rascunho
{
    class Program
    {
        class MultiDimensional
        {
            private string[,] _guideNames = new string[10, 10];

            public string this[int x, int y]
            {
                get { return _guideNames[x, y]; }
                set { _guideNames[x, y] = value; }
            }
            public string this[float x, float y]
            {
                get { return _guideNames[0, 0]; }
                set { _guideNames[0, 0] = value; }
            }
        }

        static void Main(string[] args)
        {
            MultiDimensional theMatrix = new MultiDimensional();
            //theMatrix[0, 0] = "Daniel";
            theMatrix[0.0f, 1.0f] = "Florian";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (theMatrix[i, j] == null) { Console.Write("N.A. "); }
                    else { Console.Write($"{theMatrix[i, j]} "); }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
