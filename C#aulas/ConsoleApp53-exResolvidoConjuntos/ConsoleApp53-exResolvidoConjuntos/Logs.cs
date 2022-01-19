using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53_exResolvidoConjuntos
{
    class Logs
    {
        public string UserName;
        public DateTime Instant;

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Logs))
            {
                return false;
            }
            Logs other = obj as Logs;
            return UserName.Equals(other.UserName);

        }
    }
}
