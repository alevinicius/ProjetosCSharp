using System;

namespace Ex_Vetor_03 {
    public class Estudante {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Estudante(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return $"{Nome}, {Email}";
        }
    }

    class Program {
        static void Main(string[] args) {

            Estudante[] estudantes = new Estudante[10];

            Console.Write("Quantos estudantes alugarão quartos? (Máximo de 10) ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < n; i++) {
                bool selecionouQuartoVago = false;

                Console.Write("Nome do {0}º estudante: ", i + 1);
                string nome = Console.ReadLine();

                Console.Write("Email do {0}º estudante: ", i + 1);
                string email = Console.ReadLine();                

                for (int j = 0; j < 10; j++) {
                    if(estudantes[j] != null) {
                        Console.WriteLine($"Quarto {j}: OCUPADO");
                    } else {
                        Console.WriteLine($"Quarto {j}: VAGO");
                    }
                }

                while (!selecionouQuartoVago) {
                    Console.Write("Selecione um quarto vago: ");
                    int numeroQuarto = int.Parse(Console.ReadLine());

                    if(estudantes[numeroQuarto] == null) {
                        selecionouQuartoVago = true;
                        estudantes[numeroQuarto] = new Estudante(nome, email);
                    } else {
                        Console.Write("Quarto ocupado. ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (estudantes[i] != null) {
                    Console.WriteLine($"{i}: {estudantes[i]}");
                }
            }            
        }
    }
}
