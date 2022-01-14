using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp26_enumeracoes_p1.entities;

namespace ConsoleApp26_enumeracoes_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            // crtl k d
            // enum  -- string to enum

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            // OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), value: "Delivered");

            Console.WriteLine(os);

            // OrderStatus os;
            // Enum.TryParse("Delivered", out os);

        }
    }
}

