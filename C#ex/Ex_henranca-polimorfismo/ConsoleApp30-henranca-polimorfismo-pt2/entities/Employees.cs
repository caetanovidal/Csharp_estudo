using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30_henranca_polimorfismo_pt2.entities
{
    class Employees
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employees()
        {

        }

        public Employees(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return $"{Name} - $ {Payment().ToString("F2")}";
        }
    }
}
