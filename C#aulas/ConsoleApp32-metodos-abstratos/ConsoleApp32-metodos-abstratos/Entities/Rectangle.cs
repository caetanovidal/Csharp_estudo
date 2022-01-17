using ConsoleApp32_metodos_abstratos.Entities.Enum;

namespace ConsoleApp32_metodos_abstratos.Entities
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(Color color, double height, double width) : base(color)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
