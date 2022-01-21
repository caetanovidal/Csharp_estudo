using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExInterfaceTentativa3.Entities;

namespace ExInterfaceTentativa3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Installment> lInstallm = new List<Installment>();

            lInstallm.Add(new Installment(DateTime.Now, 2000));
            lInstallm.Add(new Installment(DateTime.Now, 2000));
            lInstallm.Add(new Installment(DateTime.Now, 2000));
            lInstallm.Add(new Installment(DateTime.Now, 2000));
            lInstallm.Add(new Installment(DateTime.Now, 2000));
        }
    }
}
