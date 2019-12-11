using System;
using System.Globalization;

namespace ProblemaSemOO
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaTrianguloX = CalcularAreaTriangulo('X');            
            double areaTrianguloY = CalcularAreaTriangulo('Y');

            if (areaTrianguloX > areaTrianguloY)
            {
                Console.WriteLine("O triângulo de maior área é o X.");
            }
            else if (areaTrianguloY > areaTrianguloX)
            {
                Console.WriteLine("O triângulo de maior área é o Y.");
            }
            else
            {
                Console.WriteLine("As áreas dos triângulos são iguais.");
            }

            Console.WriteLine("******************************");
        }

        static double CalcularAreaTriangulo(char triangulo) 
        {
            double a, b, c, p;

            Console.WriteLine("Informe as medidas do triângulo {0}:", triangulo);
            Console.Write("Lado A: "); a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: "); b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: "); c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"A área do triângulo {triangulo} é: {area.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine("******************************");

            return area;
        }
    }
}
