using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rascunho2
{
    class Program
    {
        public class MakeDictionary
        {
            Dictionary<int, string> DictSensor;

            public MakeDictionary(Dictionary<int, string> dict)
            {
                DictSensor = dict;
            }

            public void Add (int id, string valor)
            {
                DictSensor.Add(id, valor);
            }

            public void Remove(int id)
            {
                DictSensor.Remove(id);
            }

            public void Read()
            {
                foreach (var x in DictSensor)
                {
                    Console.WriteLine(x.Value);
                }
            }
        }
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            MakeDictionary makeDictionary = new MakeDictionary(dict);

            makeDictionary.Add(0, "dale");
            makeDictionary.Add(1, "shesk");
            makeDictionary.Add(2, "b");
            makeDictionary.Add(3, "c");
            makeDictionary.Add(4, "d");
            makeDictionary.Remove(0);

            makeDictionary.Read();

        }
    }
}
