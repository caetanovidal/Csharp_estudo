using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp38_BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Windows\estudos\C#aulas\ConsoleApp38-BlocoUsing\file1.txt";

            try
            {


                /*
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
                */

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocured: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
