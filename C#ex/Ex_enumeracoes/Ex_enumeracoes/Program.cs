using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_enumeracoes.entities;

namespace Ex_enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth data (DD/MM/YYYY): ");
            DateTime BirthDay = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            
            

            Client cli = new Client(name, email, BirthDay);

            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, cli);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i=0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data: ");
                Console.Write("Product name: ");
                string nameProd = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProd = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());

                Product prod = new Product(nameProd, priceProd);

                OrdemItem item = new OrdemItem(quant, priceProd, prod);

                order.AddItem(item);

            }

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
            

        }
    }
}
