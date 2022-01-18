using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp40_Directory_DicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Windows\estudos\C#aulas\ConsoleApp40-Directory-DicInfo\myfolder";

            try
            {
                // ↓ faz uma pusca no path por um arquivo generico(*.*) e lista todos os 
                // diretorios e subDiretorios
                // ↓ da pra usar var tbm
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                // ↓ buscar no path, tal coisa, e trazer todos os arquivos.
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                // criar pasta

                // Directory.CreateDirectory(path + "/newfolder");               

            }

            catch (IOException e)
            {
                Console.WriteLine("An error occured: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
