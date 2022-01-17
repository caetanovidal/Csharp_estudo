using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_enumeracoes.entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }
        public List<OrdemItem> Itens { get; set; } = new List<OrdemItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrdemItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrdemItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach (OrdemItem i in Itens)
            {
                sum += i.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items: ");

            foreach (OrdemItem i in Itens)
            {
                sb.AppendLine(i.ToString());
            }

            sb.AppendLine($"Total price: ${Total().ToString("F2")}");


            return sb.ToString();
        }
    }
}
