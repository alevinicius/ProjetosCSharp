using System;
using System.Globalization;

namespace QuartoExercicio
{
    class Program
    {
        /*
         Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
         casas decimais conforme exemplos.
         Fórmula da área: area = π . raio2
         Considere o valor de π = 3.14159
         */

        static void Main(string[] args)
        {
            Console.Write("Informe o raio do círculo: "); double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2.0);

            Console.WriteLine("A área do círculo é: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
