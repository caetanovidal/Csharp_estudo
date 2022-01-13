using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_employees_list
{
    class Employess
    {
        public int Id { get; private set; }
        public string Name;
        public double Salary { get; private set; }

        public Employess(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        
        public void Increase(double percentage)
        {
            Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2");
        }

        public static bool Valid_id(int id, List<Employess> lista)
        {
            foreach (Employess dados in lista)
            {
                if (dados.Id == id){
                    return false;
                }
            }
            return true;
        }   
    }
}
