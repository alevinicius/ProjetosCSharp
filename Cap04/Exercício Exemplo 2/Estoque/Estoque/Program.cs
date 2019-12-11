using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Informe os dados do produto: ");
            Console.Write("Nome: "); p.Nome = Console.ReadLine();
            Console.Write("Preço: "); p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: "); p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");            
            p.AdicionarProdutos(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados do produto: " + p);

            Console.WriteLine("");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados atualizados do produto: " + p);

            Console.WriteLine("");
        }
    }
}
