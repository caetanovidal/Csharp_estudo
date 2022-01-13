using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno_opp
{
    class Aluno
    {
        public string Name;
        public double A, B, C;

        public string Resultado()
        {
            double sum = A + B + C;
            if (sum >= 60)
            {
                return "Nota final = " + sum + "%nAPROVADO";
            }
            else
            {
                return "Nota final = " + sum + "%nREPROVADO"
                    + "/Faltaram " + (60 - sum) + " pontos"; 
            }
        }
    }
}
