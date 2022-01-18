using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp39_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Windows\estudos\C#aulas\ConsoleApp39-StreamWriter\file1.txt";
            string targetPath = @"C:\Users\Windows\estudos\C#aulas\ConsoleApp39-StreamWriter\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
