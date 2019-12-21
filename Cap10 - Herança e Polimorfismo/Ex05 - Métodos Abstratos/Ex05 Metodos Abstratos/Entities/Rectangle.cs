using Ex05_Metodos_Abstratos.Enums;

namespace Ex05_Metodos_Abstratos.Entities
{
    class Rectangle: Shape
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }

        public Rectangle(Color color, double width, double height)
            :base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
