using System;
using System.Globalization;

using Ex02.Entities;
using Ex02.Services;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date(dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Value: ");
            double value = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Enter number of installments: ");
            int totalMouths = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);
            ContractService contractService = new ContractService();
            contractService.ProcessInstallments(contract, totalMouths, new PaypalService());

            Console.WriteLine("Installments: ");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }


        }
    }
}
