using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a002_SRP
{
    class RegistraLog : ILogger
    {
        public void Info(string info)
        {
            Console.WriteLine(info);
        }
    }
}
