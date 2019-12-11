using System;
using System.Globalization;

namespace ExercicioFixacao_01 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("MANUTENÇÃO DE CONTA");
            Console.WriteLine();

            Console.Write("Número da conta: "); int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: "); string nomeTitular = Console.ReadLine();
            Console.Write("Deseja realizar um depósito inicial? (s/n) ");
            bool realizarDepositoInicial = Console.ReadLine() == "s";

            Conta c;
            if (realizarDepositoInicial) {
                Console.Write("Valor do depósito inicial: R$ ");
                c = new Conta(nomeTitular, numeroConta, double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            } else {
                c = new Conta(nomeTitular, numeroConta);
            }

            Console.WriteLine($"Dados da conta ({c})");

            string operacao = "0";
            while (operacao != "4") {
                Console.WriteLine();
                Console.WriteLine("Escolha uma operação: ");
                Console.WriteLine("1 - Depositar ");
                Console.WriteLine("2 - Sacar ");
                Console.WriteLine("3 - Atualizar o nome do titular ");
                Console.WriteLine("4 - Finalizar o programa ");
                Console.Write("Ação desejada: "); operacao = Console.ReadLine();

                if (operacao == "1" || operacao == "2" || operacao == "3" || operacao == "4") {
                    if (operacao == "1") {
                        Console.Write("Entre com um valor para depósito: R$ ");
                        c.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                    } else if (operacao == "2") {
                        Console.Write("Entre com um valor para saque: R$ ");
                        c.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                    } else if (operacao == "3") {
                        Console.Write("Entre com o novo nome do titular: ");
                        c.NomeTitular = Console.ReadLine();                        
                    }
                    Console.WriteLine($"Dados da conta atualizados ({c})");
                } else {
                    Console.WriteLine("Erro: Operação inválida!!!");
                }
            }
        }
    }
}



