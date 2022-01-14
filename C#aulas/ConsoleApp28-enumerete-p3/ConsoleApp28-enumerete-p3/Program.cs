using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp28_enumerete_p3.Entities;

namespace ConsoleApp28_enumerete_p3
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                    DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", 
                    "I'm going to visit this wonderful country", 12
                    );
            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("Good night!");
            Comment c4 = new Comment("NICE!");
            Post p2 = new Post(
                    DateTime.Parse("28/10/2018 13:05:44"), "GN guys",
                    "See ya", 85
                    );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
