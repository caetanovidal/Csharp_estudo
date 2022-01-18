using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp36_File_Fileinfo
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = "C:\\Users\\Windows\\estudos\\file1.txt";
            string targetPath = "C:\\Users\\Windows\\estudos\\file2.txt";

            try
            {
                FileInfo fileType1 = new FileInfo(sourcePath);
                //fileType1.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
