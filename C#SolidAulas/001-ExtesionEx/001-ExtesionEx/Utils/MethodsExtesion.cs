using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ExtesionEx.Utils
{
    public static class MethodsExtesion
    {
        public static string Titulo(this string obj)
        {
            if (obj.Length > 0)
            {
                char[] array = obj.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return obj;
        }
    }
}
