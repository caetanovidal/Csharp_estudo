using ConsoleApp32_metodos_abstratos.Entities.Enum;

namespace ConsoleApp32_metodos_abstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        
        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
