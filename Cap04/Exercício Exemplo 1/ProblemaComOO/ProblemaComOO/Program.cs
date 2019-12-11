using System;
using System.Globalization;

namespace ProblemaComOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            Triangulo x = CriarTriangulo();
            double areaX = x.Area();
            Console.WriteLine("A área do triângulo X é " + areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("*******************************");

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            Triangulo y = CriarTriangulo();
            double areaY = y.Area();
            Console.WriteLine("A área do triângulo Y é " + areaY.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("*******************************");

            if (areaX > areaY)
            {
                Console.WriteLine("X tem área maior");
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("Y tem área maior");
            }
            else
            {
                Console.WriteLine("As áreas são iguais");
            }
        }

        static Triangulo CriarTriangulo()
        {
            Triangulo t = new Triangulo();        
            Console.Write("lado A: "); t.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("lado B: "); t.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("lado C: "); t.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                       
            return t;
        }
    }
}
