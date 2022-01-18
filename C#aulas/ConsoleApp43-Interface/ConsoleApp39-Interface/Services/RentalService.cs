using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp39_Interface.Entities;

namespace ConsoleApp39_Interface.Services
{
    class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoce(CarRental rental)
        {
            TimeSpan duratation = rental.Finish.Subtract(rental.Start);

            double basicPayment = 0.0;

            if (duratation.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duratation.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duratation.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            rental.Payment = new Invoce(basicPayment, tax);
        }
    }
}
