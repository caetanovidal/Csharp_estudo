using ConsoleApp32_metodos_abstratos.Entities.Enum;
using System;

namespace ConsoleApp32_metodos_abstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base (color)
        {
            Radius = radius;
        }


        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
