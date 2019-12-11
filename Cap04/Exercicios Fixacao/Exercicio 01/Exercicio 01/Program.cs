using System;
using System.Globalization;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a altura e a largura do retângulo: ");
            Retangulo ret = new Retangulo();
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área: " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("");
        }
    }
}
