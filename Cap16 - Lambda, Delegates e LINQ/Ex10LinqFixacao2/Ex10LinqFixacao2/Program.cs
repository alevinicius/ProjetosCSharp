using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

using Ex10.Entidades;

/*
 * Fazer um programa para ler os dados(nome, email e salário)
 * de funcionários a partir de um arquivo em formato .csv
 * 
 * Em seguida mostrar, em ordem alfabética, o email dos 
 * funcionários cujo salário seja superior a um dado valor fornecido pelo usuário
 * 
 * Mostrar também a soma dos salários dos funcionários cujos
 * nomes começam com a letra 'M'
 */
namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lendo o arquivo CSV e armazenando as informações em uma lista de funcionários
            string csvEntrada = @"D:\Cursos\C# COMPLETO 2019 POO\Projetos\Cap16 - Lambda, Delegates e LINQ\Ex10LinqFixacao2\funcionarios.csv";
            List<Funcionario> funcionarios = new List<Funcionario>();
            using (StreamReader sr = new StreamReader(File.OpenRead(csvEntrada)))
            {
                while (!sr.EndOfStream)
                {
                    string[] campos = sr.ReadLine().Split(';');
                    string nome = campos[0];
                    string email = campos[1];
                    double salario = double.Parse(campos[2], CultureInfo.InvariantCulture);

                    funcionarios.Add(new Funcionario(nome, email, salario));
                }
            }
            Console.WriteLine("Lista completa de funcionários: ");
            funcionarios.ForEach(p => Console.WriteLine(p));
            Console.WriteLine();
            
            Console.Write("Listar em ordem alfabética os e-mails dos funcionários com salários superior a: ");
            double salarioRestricao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            IEnumerable<string> listaEmails = funcionarios
                .Where(f => f.Salario > salarioRestricao)
                .OrderBy(f => f.Nome)
                .Select(f => f.Email);

            foreach (string email in listaEmails)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine();

            double somaSalarios = funcionarios.Where(f => f.Nome[0] == 'M').Sum(f => f.Salario);
            Console.WriteLine("A soma dos salários dos funcionários cujos nomes começam com a letra 'M' é: " 
                + somaSalarios.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
