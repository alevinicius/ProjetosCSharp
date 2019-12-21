using System;
using System.Globalization;
using System.Collections.Generic;

using Ex06_Metodos_Abstratos.Entities;

namespace Ex06_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            List<Pessoa> pessoas = new List<Pessoa>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Dados da {i}ª pessoa: ");
                Console.Write("Pessoa Física ou Jurídica (f/j): ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 'j')
                {
                    Console.Write("Número de empregados: ");
                    int numeroDeEmpregados = int.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaJuridica(nome, rendaAnual, numeroDeEmpregados));
                }
                else
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoas.Add(new PessoaFisica(nome, rendaAnual, gastosComSaude));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAGAMENTOS DE IMPOSTOS: ");
            double totalDeImpostos = 0.0;
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
                totalDeImpostos += pessoa.Impostos();
            }
            Console.WriteLine("TOTAL: $" + totalDeImpostos.ToString("F2", CultureInfo.InvariantCulture));            
        }
    }
}
