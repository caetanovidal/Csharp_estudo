using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_employees_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employess> list_funcionarios = new List<Employess>();

            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Emplyoee #" + (i+1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                if (list_funcionarios.Count > 0)
                {
                   
                    while (! Employess.Valid_id(id, list_funcionarios))
                    {
                        Console.WriteLine("ID INVALIDO");
                        Console.Write("Digite um ID valido: ");
                        id = int.Parse(Console.ReadLine());
                            
                    }
                    
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                Employess func = new Employess(id, name, salary);
                list_funcionarios.Add(func);

            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int incr_id = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double incr = double.Parse(Console.ReadLine());

            

            if ( ! Employess.Valid_id(incr_id, list_funcionarios))
            {
                foreach (Employess dados in list_funcionarios)
                {
                    if (dados.Id == incr_id)
                    {
                        dados.Increase(incr);
                    }
                }    
            }
            else
            {
                Console.WriteLine("Id incorreto");
            }

            Console.WriteLine("Upadated list of employees: ");
            foreach (Employess dados in list_funcionarios)
            {
                Console.WriteLine(dados);
            }

            Console.ReadLine();
        }
    }
}
