using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51_HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Computer");
            set.Add("Computer");
            set.Add("Computer");


            Console.WriteLine(set.Contains("Notebookk"));

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("--------------------------------" );

            SortedSet<int> a = new SortedSet<int> { 0, 2, 3, 4, 5, 5, 5, 10 };

            SortedSet<int> b = new SortedSet<int> { 5, 6, 7, 9, 3, 1 };

            PrinCollection(a);
            PrinCollection(b);

            // union

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            PrinCollection(c);

            // intersection

            SortedSet<int> d = new SortedSet<int>(a);

            d.IntersectWith(b);

            PrinCollection(d);

            // difference

            SortedSet<int> e = new SortedSet<int>(a);

            e.ExceptWith(b);

            PrinCollection(e); 

        }
        static void PrinCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }

}
