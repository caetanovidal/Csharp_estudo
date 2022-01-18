using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp37_FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Windows\estudos\C#aulas\ConsoleApp37-FileStream-StreamReader\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(sr != null) sr.Close();
                if(fs !=null) fs.Close();
            }
        }
    }
}
