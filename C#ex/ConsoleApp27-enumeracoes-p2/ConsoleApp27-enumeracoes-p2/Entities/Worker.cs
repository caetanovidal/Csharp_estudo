﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp27_enumeracoes_p2.Entities.Enum;

namespace ConsoleApp27_enumeracoes_p2.Entities
{
    class Worker
    {
    
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } 
            = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, 
            double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }


        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }


        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract dados in Contracts)
            {
                if (dados.Date.Year == year && dados.Date.Month == month)
                {
                    sum += dados.TotalValue();
                }
            }
            return sum;
        }
    }
}
