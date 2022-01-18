using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Ex_arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Windows\estudos\C#ex\Ex_arquivos\Source.txt";
            string targetPath = @"C:\Users\Windows\estudos\C#ex\Ex_arquivos\OutputFile\output.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] words = line.Split(',');

                        string name = words[0];
                        double price = double.Parse(words[1], CultureInfo.InvariantCulture);
                        int quant = int.Parse(words[2]);
                        double res = price * quant;

                        sw.WriteLine(words[0] + ", " + res.ToString(CultureInfo.InvariantCulture));

                        //foreach (string w in words) debug print's
                        //{
                        //    Console.WriteLine(w);
                        //}
                    }
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
