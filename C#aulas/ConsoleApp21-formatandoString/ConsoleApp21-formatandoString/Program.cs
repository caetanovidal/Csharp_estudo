using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21_formatandoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abasc DHSAI dasdas SADAsd    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("da");
            int n2 = original.LastIndexOf("a");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine("-" + original + "-");
            Console.WriteLine("-" + s1 + "-");
            Console.WriteLine("-" + s2 + "-");
            Console.WriteLine("-" + s3 + "-");
            Console.WriteLine("-" + n1 + "-");
            Console.WriteLine("-" + n2 + "-");
            Console.WriteLine("-" + s4 + "-");
            Console.WriteLine("-" + s5 + "-");
            Console.WriteLine("-" + s6 + "-");
            Console.WriteLine("-" + b1 + "-");
            Console.WriteLine("-" + b2 + "-");







        }
    }
}
