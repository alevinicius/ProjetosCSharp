using System;
using System.Globalization;

namespace _02___SegundoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa? ");
            int qtdeQuartos = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Entre com seu último nome, idade e altura (na mesma linha): ");
            string[] vetAux = Console.ReadLine().Split(' ');

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdeQuartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vetAux[0]);
            Console.WriteLine(vetAux[1]);
            Console.WriteLine(vetAux[2], "F2", CultureInfo.InvariantCulture);

        }
    }
}
