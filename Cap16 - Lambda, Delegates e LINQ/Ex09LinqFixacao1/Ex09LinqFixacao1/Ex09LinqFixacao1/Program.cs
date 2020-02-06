using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

using Ex09.Entidades;

/*
 * Fazer um programa para ler um conjunto de produtos a partir de um arquivo
 * em formato .csv.
 * 
 * Em seguida mostrar o preço médio dos produtos. 
 * Depois, mostrar os nomes, em ordem decrescente dos produtos que possuem preço inferior ao preço médio
*/

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvEntrada = @"D:\Cursos\C# COMPLETO 2019 POO\Projetos\Cap16 - Lambda, Delegates e LINQ\Ex09LinqFixacao1\produtos.csv";

            List<Produto> produtos = new List<Produto>();
            using (StreamReader sr = new StreamReader(File.OpenRead(csvEntrada)))
            {
                while (!sr.EndOfStream)
                {
                    string[] campos = sr.ReadLine().Split(';');
                    string nome = campos[0];
                    double preco = double.Parse(campos[1], CultureInfo.InvariantCulture);
                    produtos.Add(new Produto(nome, preco));
                }
            }

            double precoMedio = produtos.Average(p => p.Preco);
            Console.WriteLine($"O preço médio dos produtos é: {precoMedio.ToString("F2", CultureInfo.InvariantCulture)} ");
            Console.WriteLine();
            Console.WriteLine("Os nomes produtos com preço abaixo da média são (Ordem decrescente): ");

            //Usando sintaxe lambda comum
            var nomesProdutosBaratos = produtos.Where(p => p.Preco < precoMedio).OrderByDescending(p => p.Nome).Select(p => p.Nome);
            
            //Usando sintaxe lambda alternativa, semelhante ao SQL
            var nomesProdutosBaratos2 = from p in produtos where p.Preco < precoMedio orderby p.Nome descending select p.Nome;

            //Aqui pode-se usar tanto a variável "nomeProdutosBaratos" como a "nomesProdutosBaratos2", tanto faz
            //Fiz as duas apenas para deixar registradas as duas sintaxes possíveis que podem ser usadas para filtrar e ordenar
            foreach (string nomeProduto in nomesProdutosBaratos)
            {
                Console.WriteLine(nomeProduto);
            }
        }
    }
}
