using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp39_Interface.Entities;
using ConsoleApp39_Interface.Services;

namespace ConsoleApp39_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();

            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine());

            CarRental rent = new CarRental(start, finish, new Vehicle(model));

            RentalService service = new RentalService(hour, day, new BrazilTaxService());

            service.ProcessInvoce(rent);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(rent.Payment);

        }
    }
}
 