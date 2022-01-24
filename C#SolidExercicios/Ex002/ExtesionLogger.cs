using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex002
{
    public static class ExtesionLogger
    {
        public static void LoggerTxt(this string mensagem)
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
