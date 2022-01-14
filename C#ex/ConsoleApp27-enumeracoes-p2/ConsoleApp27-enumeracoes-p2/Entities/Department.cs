using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27_enumeracoes_p2.Entities
{
    class Department
    {
        private string _name;

        public Department()
        {
        }

        public Department(string name)
        {
            _name = name;
        }
        public string Nome
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }


    }
}
