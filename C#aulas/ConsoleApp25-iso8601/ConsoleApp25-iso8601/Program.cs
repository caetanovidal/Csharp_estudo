using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25_iso8601
{
    class Program
    {
        static void Main(string[] args)
        {
            //armazernar em UTC gmt ( texto: BD/Json/XML )
            //apresentar em horario local

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: "+d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 Localtime: " + d1.ToLocalTime());
            Console.WriteLine("d1 UniversalTime: " + d1.ToUniversalTime());

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 Localtime: " + d2.ToLocalTime());
            Console.WriteLine("d2 UniversalTime: " + d2.ToUniversalTime());

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 Localtime: " + d3.ToLocalTime());
            Console.WriteLine("d3 UniversalTime: " + d3.ToUniversalTime());



            // ISO 8601 yyyy-MM-ddTHH:mm:ssz

            DateTime d4 = DateTime.Parse("2000-10-02 13:20:14");
            DateTime d5 = DateTime.Parse("2000-08-01 14:12:10Z");


            Console.WriteLine("d4: " + d4);
            Console.WriteLine("d4: Kind: " + d4.Kind);
            Console.WriteLine("d4: Localtime: " + d4.ToLocalTime());
            Console.WriteLine("d4: UniversalTime: " + d4.ToUniversalTime());

            Console.WriteLine("d5: " + d5);
            Console.WriteLine("d5: Kind: " + d5.Kind);
            Console.WriteLine("d5: Localtime: " + d5.ToLocalTime());
            Console.WriteLine("d5: UniversalTime: " + d5.ToUniversalTime());
            

        }
    }
}
