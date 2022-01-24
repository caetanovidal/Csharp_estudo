using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a005_AplicandoSOLIDpratica
{
    class Program

    {
        static void Main(string[] args)
        {
            ICalculaDescontoFidelidade descFide = new CalculoDescontoFidelidade();
            ICalculaDescontoStatusContaFactory descConta = new CalculaDescontoStatusContaFactory();

            GerenciadorDeDescontos gerDesc = new GerenciadorDeDescontos(descFide, descConta);

            Console.WriteLine("Valor da compra 1000 e fidelidade 10 (5%)\n");
            var resultado1 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);

            Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto é de: {resultado1}");

            var resultado2 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 10);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto é de: {resultado2}");

            var resultado3 = gerDesc.AplicarDesconto(1000, StatusContaCliente.ClienteVIP, 10);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteVIP}, valor do desconto é de: {resultado3}");

        }
    
    }
}
