using System;
using System.Globalization;

namespace SetimoExercicio
{
    class Program
    {
        /*
         Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
         código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Informe o Código, Quantidade e Valor Unitário da Peça 1: ");
            string[] peca1 = Console.ReadLine().Split(' ');
            
            Console.WriteLine("Informe o Código, Quantidade e Valor Unitário da Peça 2: ");
            string[] peca2 = Console.ReadLine().Split(' ');

            double valorPeca1 = double.Parse(peca1[1]) * double.Parse(peca1[2], CultureInfo.InvariantCulture);
            double valorPeca2 = double.Parse(peca2[1]) * double.Parse(peca2[2], CultureInfo.InvariantCulture);
            double valorTotal = valorPeca1 + valorPeca2;

            Console.WriteLine("O valor total a pagar é de " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
