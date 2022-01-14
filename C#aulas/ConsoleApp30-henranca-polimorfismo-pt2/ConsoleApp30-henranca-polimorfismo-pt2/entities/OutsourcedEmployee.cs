using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30_henranca_polimorfismo_pt2.entities
{
    class OutsourcedEmployee : Employees
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;

        }


    }
}
