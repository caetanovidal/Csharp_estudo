using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_struct_tipos_referencia_e_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            //nullable
            Nullable<double> x = null;
            double? y = 10.0;
            double? z = null;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }
            Console.WriteLine("-----------------------------------------------------");
            // -----------------------------------

            // coalescencia nula

            double? a = null;
            double? b = 10;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);


            // ---------------------------
            Console.WriteLine("-----------------------------------------------------");
            Point p;
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p = new Point();

            Console.WriteLine(p);
        }
    }
}
