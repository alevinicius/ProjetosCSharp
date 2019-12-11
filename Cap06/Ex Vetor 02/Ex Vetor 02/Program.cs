using System;
using System.Globalization;

namespace Ex_Vetor_02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Quantos produtos você tem? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Produto[] produtos = new Produto[n];
            double soma = 0.0;

            for (int i = 0; i < n; i++) {
                Console.Write("Informe o nome do {0}º produto: ", i + 1);
                string nome = Console.ReadLine();

                Console.Write("Informe o preço do {0}º produto: ", i + 1);
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += preco;

                produtos[i] = new Produto() { Nome = nome, Preco = preco };
                
                Console.WriteLine();
            }
            Console.WriteLine();            
            Console.WriteLine("A média dos preços dos produtos é " + (soma / n).ToString("F2", CultureInfo.InvariantCulture));            
        }
    }
}
