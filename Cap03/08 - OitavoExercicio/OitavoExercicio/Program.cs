using System;
using System.Globalization;

namespace OitavoExercicio
{
    class Program
    {
        /*
         *  Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.
         */

        static void Main(string[] args)
        {
            Console.Write("Informe os valores de 'A', 'B' e 'C' respectivamente: ");
            string[] valores = Console.ReadLine().Split(' ');
            float a = float.Parse(valores[0], CultureInfo.InvariantCulture);
            float b = float.Parse(valores[1], CultureInfo.InvariantCulture);
            float c = float.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine("AS ÁREAS DAS FORMAS SÃO: ");
            double trianguloRetangulo = a * c / 2;
            double circulo = 3.14159 * Math.Pow(c, 2);
            double trapezio = (a + b) * c / 2;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;

            Console.WriteLine("Triângulo Retângulo: " + trianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Círculo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapézio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
