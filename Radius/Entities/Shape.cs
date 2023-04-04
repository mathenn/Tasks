using Radius.Entities.Enum;

namespace Radius.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public List<Shape> Shapes { get; set; } = new List<Shape>();

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
