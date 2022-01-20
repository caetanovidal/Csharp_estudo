using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source

            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression

            // ↓ IEnurable<int>
            var result = numbers.Where(x => x % 2 == 0)
                .Select(p => p * 10);

            // Execute the query

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

        }
    }
}
