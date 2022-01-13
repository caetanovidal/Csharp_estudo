using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17_list_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string>() { "Maria", "Alice", "Bob" };

            list.Add("Joao");
            list.Add("Alex");
            list.Add("Bob");
            list.Insert(0, "Marco");
            list.Add("Marcio");

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("List Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');

            Console.WriteLine(s1);

            Console.WriteLine("---------------------------------------------------");


            string s2 = list.FindLast(x => x[0] == 'M');

            Console.WriteLine(s2);

            Console.WriteLine("---------------------------------------------------");


            int pos = list.FindIndex(x => x[0] == 'A');

            Console.WriteLine(pos);

            Console.WriteLine("---------------------------------------------------");


            List<string> listRes = list.FindAll(x => x.Length > 4);

            foreach (string name in listRes)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("---------------------------------------------------");

            list.Remove("Alex");

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("---------------------------------------------------");

            list.RemoveAll(x => x[0] == 'M');

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            list.RemoveRange(0, 2);

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("---------------------------------------------------");

        }
    }
}
