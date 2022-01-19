using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp47_InterfaceComparable.Entities;

namespace ConsoleApp47_InterfaceComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Windows\estudos\C#aulas\ConsoleApp47-InterfaceComparable\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));

                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }

                    

                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
