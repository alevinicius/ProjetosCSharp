using System;
using System.Globalization;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double 
                n1 = -1, 
                n2 = -1, 
                n3 = -1;

            Console.WriteLine("Informe os dados do aluno: ");
            Aluno a = new Aluno();

            Console.Write("Nome: "); a.Nome = Console.ReadLine();

            while (n1 < 0 || n1 > 30)
            {
                Console.Write("Nota 1: ");
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (n1 >= 0 || n1 <= 30)
                {
                    a.Nota1 = n1;
                }
                else{
                    Console.WriteLine("A primeira nota tem que ser entre 0 e 30");
                }
            }

            while (n2 < 0 || n2 > 35)
            {
                Console.Write("Nota 2: ");
                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (n2 >= 0 || n2 <= 35)
                {
                    a.Nota2 = n2;
                }
                else
                {
                    Console.WriteLine("A segunda nota tem que ser entre 0 e 35");
                }
            }

            while (n3 < 0 || n3 > 35)
            {
                Console.Write("Nota 3: ");
                n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (n3 >= 0 || n3 >= 35)
                {
                    a.Nota3 = n3;
                }
                else
                {
                    Console.WriteLine("A terceira nota tem que ser entre 0 e 35");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("A nota final é " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a.Aprovado())
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram {0} pontos", a.PontuacaoRestante().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
