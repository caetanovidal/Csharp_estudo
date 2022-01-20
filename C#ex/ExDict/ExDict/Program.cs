using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExDict
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Windows\estudos\C#ex\ExDict\input.txt";

            StreamReader sr = File.OpenText(path);
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (!(sr.EndOfStream))
            {
                string[] vect = sr.ReadLine().Split(',');

                if (dict.ContainsKey(vect[0]))
                {
                    int x = int.Parse(vect[1]);
                    //Console.WriteLine(dict[vect[0]]);
                    //Console.WriteLine(x);
                    dict[vect[0]] += x; 
                }
                else
                {
                    
                    dict.Add(vect[0], int.Parse(vect[1]));
                }

            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
