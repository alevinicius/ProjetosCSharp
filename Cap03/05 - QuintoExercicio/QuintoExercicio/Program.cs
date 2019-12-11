using System;

namespace QuintoExercicio
{
    class Program
    {
        /*
         * Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
         */

        static void Main(string[] args)
        {
            Console.Write("Informe o valor 'A': "); int a = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor 'B': "); int b = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor 'C': "); int c = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor 'D': "); int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b) - (c * d);
            Console.WriteLine("A diferença entre A x B e C x D é " + diferenca);
        }
    }
}
