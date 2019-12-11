using System;
using System.Globalization;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? R$ ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? U$ ");
            double qtdeDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            double valorAPagar = ConversorDeMoeda.DeDolarParaReal(qtdeDolares, cotacaoDolar);
            Console.WriteLine("O valor a ser pago é de R$ " + valorAPagar.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("");
        }        
    }
}
