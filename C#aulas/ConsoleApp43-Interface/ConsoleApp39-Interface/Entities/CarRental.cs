using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39_Interface.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Car { get; set; }
        public Invoce Payment { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle car)
        {
            Start = start;
            Finish = finish;
            Car = car;
            Payment = null;
        }


    }
}
