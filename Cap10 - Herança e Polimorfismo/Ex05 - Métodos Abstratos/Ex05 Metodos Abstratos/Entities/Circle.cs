using Ex05_Metodos_Abstratos.Enums;
using System;

namespace Ex05_Metodos_Abstratos.Entities
{
    class Circle: Shape
    {
        public double Radius { get; protected set; }

        public Circle(Color color, double radius)
            :base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.1416 * Math.Pow(Radius, 2);
        }
    }
}
