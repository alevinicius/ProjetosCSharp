using System;

namespace T02 {

    struct Ponto {
        public double X;
        public double Y;

        public override string ToString() {
            return $"({X},{Y})";
        }

    }

    class Program {
        static void Main(string[] args) {
            Ponto p;
            p.X = 5;
            p.Y = 10;           
            Console.WriteLine(p);
            p = new Ponto();
            Console.WriteLine(p);
        }
    }
}
