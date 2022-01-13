using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_quarto
{
    class Program
    {
        static void Main(string[] args)
        {
            Quartos[] quart = new Quartos[9];
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Rent #" + (i+1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                if (quart[room] == null)
                {
                    quart[room] = new Quartos { Name = name, Email = email, Room = room };
                }
                else
                {
                    Console.WriteLine("Quarto ocupado");
                }
            }

            Console.WriteLine("Busy rooms:");
            for (int i=0; i<9; i++)
            {
                if (quart[i] != null)
                {
                    Console.WriteLine(quart[i]);
                }
            }
        }
    }
}
