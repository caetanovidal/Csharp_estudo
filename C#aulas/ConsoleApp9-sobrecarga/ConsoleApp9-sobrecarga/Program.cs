using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
       

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            int quant = int.Parse(Console.ReadLine());

            Product x = new Product(name, price, quant);

            Console.WriteLine(x.name);

            Console.WriteLine($"Dados do produto: " + x);

            Console.WriteLine("Digete o numero de produtos a ser adicionado ao estoque: ");

            int increase = int.Parse(Console.ReadLine());

            x.Add(increase);

            Console.WriteLine($"Dados atualizados: " + x);

            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");

            int decrease = int.Parse(Console.ReadLine());

            x.Remove(decrease);

            Console.WriteLine("Dados atualizado: " + x);

            Console.ReadLine();
        }
    }
}
