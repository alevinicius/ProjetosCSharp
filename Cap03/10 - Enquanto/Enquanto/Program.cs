using System;

namespace Enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número não negativo e lhe mostraremos sua raiz quadrada");
            Console.WriteLine("Digite um número negativo e encerraremos o programa");
            Console.WriteLine("-------------------------------------------------------------");

            int numero = 0;
            while (numero >= 0)
            {
                Console.Write("Digíte um número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero >= 0)
                {
                    Console.WriteLine($"A raiz quadrada de {numero} é {Math.Sqrt(numero)}");
                }
                else
                {
                    Console.WriteLine("O {0} é um número negativo. Fim do programa", numero);
                }
                Console.WriteLine("");
            }
        }
    }
}
