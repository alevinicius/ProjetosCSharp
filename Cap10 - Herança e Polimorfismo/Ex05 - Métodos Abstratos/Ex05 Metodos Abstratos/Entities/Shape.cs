using Ex05_Metodos_Abstratos.Enums;

namespace Ex05_Metodos_Abstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; protected set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
