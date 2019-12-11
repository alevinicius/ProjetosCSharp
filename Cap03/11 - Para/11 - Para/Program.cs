using System;

namespace _11___Para
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números você vai digitar? ");
            int qtdeNumeros = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= qtdeNumeros; i++)
            {
                Console.Write("Digite o {0}º valor: ", i);
                soma += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("A soma dos números é "+ soma);
        }
    }
}
