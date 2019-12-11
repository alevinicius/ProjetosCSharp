using System;
using System.Globalization;

namespace Ex_Vetor_01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe o tamanho a quantidade de alunos: "); int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write($"Informe a altura do {i + 1}º aluno: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine();
            double soma = 0.0;

            for (int i = 0; i < n; i++) {
                soma += vect[i];
            }
            double media = soma / n;
            Console.WriteLine("A média de altura dos alunos é {0}", media.ToString("F2", CultureInfo.InvariantCulture));

           
        }
    }
}
