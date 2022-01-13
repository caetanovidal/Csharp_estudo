using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_quarto
{
    class Quartos
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room;

        public override string ToString()
        {
            return Room + ": " + Name + ", " + Email;
        }

    }
}
