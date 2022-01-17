using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_classes_abstratas.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            double tax;

            if (AnualIncome > 20000)  // 25%
            {
                tax = (AnualIncome / 4) - (HealthExpenditures / 2);
            }
            else
            {
                tax = (AnualIncome * 0.15) - (HealthExpenditures / 2);
            }

            return tax;
        }
    }
}
