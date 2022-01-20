using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54_Dict_SortDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99523432";
            cookies["phone"] = "92834872";

            cookies.Remove("email");


            Console.WriteLine(cookies["phone"]);
            //Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies.Count);

            Console.WriteLine("ALL COOKIES");
            // foreach(var item in cookies)

            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }   
    }
}
