using System;
using System.Globalization;

namespace SextoExercicio
{
    class Program
    {
        /*
         * Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
           hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
           decimais.
         */

        static void Main(string[] args)
        {
            Console.Write("Informe o número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de horas trabalhadas: ");
            int qtdeHoras = int.Parse(Console.ReadLine());

            Console.Write("Informe quanto o funcionário recebe por hora: ");
            double vlrHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = qtdeHoras * vlrHora;

            Console.WriteLine("O funcionário de número {0} receberá neste mês o salário de {1} : ", numero, salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
