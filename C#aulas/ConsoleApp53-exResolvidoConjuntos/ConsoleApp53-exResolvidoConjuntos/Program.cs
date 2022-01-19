using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp53_exResolvidoConjuntos
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"C:\Users\Windows\estudos\C#aulas\ConsoleApp53-exResolvidoConjuntos\input.txt";

            HashSet<Logs> set = new HashSet<Logs>();

            try
            {

                HashSet<string> logUser = new HashSet<string>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {


                        string[] vect = sr.ReadLine().Split(' ');

                        string name = vect[0];
                        DateTime instant = DateTime.Parse(vect[1]);

                        set.Add(new Logs { UserName = name, Instant = instant});
                        

                    }
                    Console.WriteLine(set.Count);
                }

                //Console.WriteLine(logUser.Count);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
