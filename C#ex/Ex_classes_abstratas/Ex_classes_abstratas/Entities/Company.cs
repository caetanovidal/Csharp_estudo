using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_classes_abstratas.Entities
{
    class Company : TaxPayer
    {
        public int NumEmployees { get; set; }

        public Company()
        {
        }

        public Company(int numEmployees, string name, double anualIncome) 
            : base(name, anualIncome)
        {
            NumEmployees = numEmployees;
        }


        public override double TaxesPaid()
        {
            double tax = 0.0;

            if (NumEmployees > 10)
            {
                tax = AnualIncome * 0.14;
            }
            else
            {
                tax = AnualIncome * 0.16;
            }
            

            return tax;
        }
    }
}
