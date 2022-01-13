using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string name = Console.ReadLine();

            Console.WriteLine("Qauntos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha):");

            string[] vet = Console.ReadLine().Split(' ');

            string name1 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine(name);
            Console.WriteLine(quarto);
            Console.WriteLine(preco);
            Console.WriteLine(name1);
            Console.WriteLine(idade);
            Console.WriteLine(altura);






        }
    }
}
