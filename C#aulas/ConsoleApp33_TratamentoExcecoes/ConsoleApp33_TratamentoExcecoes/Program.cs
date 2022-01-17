using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33_TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);


                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é possivel dividir por 0");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format ERROR! Somente numeros inteiros sao aceitos!" );
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
