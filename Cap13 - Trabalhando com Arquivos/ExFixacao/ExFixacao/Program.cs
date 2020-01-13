using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

using ExFixacao.Entities;


namespace ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirEntrada = @"D:\Cursos\C# COMPLETO 2019 POO\Projetos\Cap13 - Trabalhando com Arquivos\ExFixacao\itensVendidos.csv";
            string dirSaida = @"D:\Cursos\C# COMPLETO 2019 POO\Projetos\Cap13 - Trabalhando com Arquivos\ExFixacao\Summary.csv";

            List<Venda> vendas = new List<Venda>();

            try
            {
                using (StreamReader sr = new StreamReader(File.OpenRead(dirEntrada)))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] campos = sr.ReadLine().Split(';');
                        string produto = campos[0];
                        double valorUnitario = double.Parse(campos[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(campos[2]);

                        Venda venda = new Venda(produto, valorUnitario, quantidade);
                        vendas.Add(venda);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }

            using (StreamWriter sw = new StreamWriter(File.OpenWrite(dirSaida)))
            {
                foreach (Venda venda in vendas)
                {
                    sw.WriteLine(venda.Produto + ";" + venda.Total.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
