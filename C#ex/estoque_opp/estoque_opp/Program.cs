using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_opp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product x = new Product();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            x.name = Console.ReadLine();
            Console.Write("Preço: ");
            x.price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            x.quant = int.Parse(Console.ReadLine());

            Console.WriteLine(x.name);

            Console.WriteLine($"Dados do produto: " + x);

            Console.WriteLine("Digete o numero de produtos a ser adicionado ao estoque: ");

            int increase = int.Parse(Console.ReadLine());

            x.add(increase);

            Console.WriteLine($"Dados atualizados: " + x);

            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");

            int decrease = int.Parse(Console.ReadLine());

            x.remove(decrease);

            Console.WriteLine("Dados atualizado: " + x);




        }

        
    }
}
