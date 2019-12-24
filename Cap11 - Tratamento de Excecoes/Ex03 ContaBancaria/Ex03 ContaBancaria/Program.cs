using System;
using System.Globalization;

using Ex03.Entidades;
using Ex03.Entidades.Exceptions;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe os dados da conta: ");
                Console.Write("Número: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string titular = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de saque: ");
                double limiteDeSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ContaBancaria contaBancaria = new ContaBancaria(numero, titular, saldo, limiteDeSaque);

                Console.WriteLine();
                Console.Write("Informe o valor que deseja sacar: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria.Sacar(saque);

                Console.WriteLine("Novo saldo: " + contaBancaria.Saldo);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro de conta bancária: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formatação: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}
