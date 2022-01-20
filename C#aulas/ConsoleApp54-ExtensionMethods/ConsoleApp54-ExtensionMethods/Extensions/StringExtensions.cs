using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54_ExtensionMethods.Extensions
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int cortar)
        {
            if (thisObj.Length <= cortar)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, cortar) + "...";
            }
        }
    }
}
