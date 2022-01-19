﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp47_InterfaceComparable.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);

        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2");
        }

        public int CompareTo(object obj)
        {
            // output -1|0|1
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing ERROR: argument is not an employee");

            }
            Employee other = obj as Employee;
            return Salary.CompareTo(other.Salary);
        }
    }
}
