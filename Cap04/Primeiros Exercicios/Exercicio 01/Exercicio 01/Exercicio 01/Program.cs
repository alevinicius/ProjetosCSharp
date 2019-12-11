using System;
using System.Globalization;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Informe os dados da primeira pessoa:");
            Pessoa p1 = new Pessoa();
            Console.Write("Nome: ");  p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");  p1.Idade = int.Parse(Console.ReadLine());
            Console.Write("Salário: "); p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine("*************************************");
            Console.WriteLine("");

            Console.WriteLine("Informe os dados da segunda pessoa:");
            Pessoa p2 = new Pessoa();
            Console.Write("Nome: "); p2.Nome = Console.ReadLine();
            Console.Write("Idade: "); p2.Idade = int.Parse(Console.ReadLine());
            Console.Write("Salário: "); p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("*************************************");

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("{0} é a pessoa mais velha", p1.Nome);
            }
            else if (p1.Idade < p2.Idade)
            {
                Console.WriteLine("{0} é a pessoa mais velha", p2.Nome);
            }
            else
            {
                Console.WriteLine("{0} e {1} tem a mesma idade", p1.Nome, p2.Nome);
            }

            double mediaSalarial = (p1.Salario + p2.Salario) / 2.00;
            Console.WriteLine("A média dos salários é " + mediaSalarial.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
