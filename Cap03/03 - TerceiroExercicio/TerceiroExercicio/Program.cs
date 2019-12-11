using System;

namespace TerceiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa*/

            Console.Write("Informe o 1º valor: "); int v1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o 2º valor: "); int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma dos valores é {v1 + v2}"); 
        }
    }
}
