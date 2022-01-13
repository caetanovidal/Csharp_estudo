using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario_opp
{
    class Funcionario
    {
        public string Name;
        public double SalaryBruto;
        public double Taxes;

        public double Salary()
        {
            return SalaryBruto - Taxes;
        }

        public void IncreaseSalary(double percentage)
        {
            SalaryBruto += SalaryBruto * percentage / 100;
        }

        public override string ToString()
        {
            return Name + ", $ " + Salary();
        }
    }
}
