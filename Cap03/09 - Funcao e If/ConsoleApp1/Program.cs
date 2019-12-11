using System;

namespace FuncaoEIf
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Digite 3 números");
            Console.Write("Número 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Número 3: ");
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("O maior número é " + resultado);
        }

        static int Maior(int a, int b, int c) {
            int m;

            if (a > b && a > c){
                m = a;
            }
            else if (b > c){
                m = b;
            }
            else{
                m = c;
            }

            return m;
        }
    }
}
