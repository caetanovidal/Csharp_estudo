using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace exLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lista = new List<Employee>();

            string path = @"C:\Users\Windows\estudos\C#ex\exLambda\input.txt";


            using (StreamReader sr = File.OpenText(path))
            {
                while (!(sr.EndOfStream))
                {
                    string[] vect = sr.ReadLine().Split(',');

                    string name = vect[0];
                    string email = vect[1];
                    double salary = double.Parse(vect[2], CultureInfo.InvariantCulture);

                    lista.Add(new Employee(name, email, salary));
                }
            }

            double salaryWant = double.Parse(Console.ReadLine());

            var r1 = lista.Where(p => p.Salary > salaryWant).OrderBy(p => p.Email).Select(p => p.Email);
            Console.WriteLine("Email of people who own more than " + salaryWant + ":");
            foreach (string x in r1)
            {
                Console.WriteLine(x);
            }

            var r0 = lista.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + r0.ToString("F2"));
            


        }
    }
}
