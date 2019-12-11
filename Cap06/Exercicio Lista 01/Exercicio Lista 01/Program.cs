using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Lista_01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Número de funcionários: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            List<Funcionario> funcionarios = new List<Funcionario>();
            bool idValido;

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Dados do {0}º funcionário ", i + 1);
                idValido = false;
                while (!idValido) {
                    Console.Write("Id: "); int id = int.Parse(Console.ReadLine());

                    Funcionario funcionario = funcionarios.Find(x => x.Id == id);
                    if (funcionario == null) {
                        idValido = true;

                        Console.Write("Nome: ");  string nome = Console.ReadLine();
                        Console.Write("Salário: "); double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        funcionario = new Funcionario(id, nome, salario);
                        funcionarios.Add(funcionario);
                    } else {
                        Console.Write("Id repetido, digite outro. ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Lista de funcionários: ");
            foreach (Funcionario funcionario in funcionarios) {
                Console.WriteLine(funcionario);
            }

            Console.WriteLine();

            idValido = false;
            while (!idValido) {
                Console.Write("Informe o Id do funcionário que receberá aumento: ");
                int id = int.Parse(Console.ReadLine());

                Funcionario funcionario = funcionarios.Find(y => y.Id == id);
                if (funcionario != null) {
                    idValido = true;
                    Console.Write($"Informe o porcentual de aumento para {funcionario.Nome}: ");
                    double porcentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    funcionario.AumentarSalario(porcentual);
                } else {
                    Console.Write("Id inexistente. ");
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Lista de funcionários: ");
            foreach (Funcionario funcionario in funcionarios) {
                Console.WriteLine(funcionario);
            }
        }
    }
}
