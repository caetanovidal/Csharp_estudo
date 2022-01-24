
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex002
{
    class FileLogger : Ilogger
    {
        public void Registrar(string mensagem)
        {
            if (mensagem.Length > 0)
            {
                string path = @"C:\Users\Windows\estudos\C#SolidExercicios\Ex002\outputLog.txt";
                try
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(mensagem);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
