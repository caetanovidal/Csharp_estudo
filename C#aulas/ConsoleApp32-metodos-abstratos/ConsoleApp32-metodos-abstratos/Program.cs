using System;
using System.Collections.Generic;
using ConsoleApp32_metodos_abstratos.Entities;
using ConsoleApp32_metodos_abstratos.Entities.Enum;

namespace ConsoleApp32_metodos_abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i+1} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char rc = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

                if (rc == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());


                    list.Add(new Rectangle(color, height, width));

                }
                if (rc == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(color, radius));
                }

                
            }
            Console.WriteLine();
            Console.WriteLine("Shape Areas: ");
            foreach (Shape shap in list)
            {
                Console.WriteLine(shap.Area().ToString("F2"));
            }
        }
    }
}
