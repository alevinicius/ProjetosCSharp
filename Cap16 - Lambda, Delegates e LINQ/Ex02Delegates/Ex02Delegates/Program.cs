using System;

using Ex02.Services;

namespace Ex02
{
    //Delegate é um tipo que eu posso criar que fará referência à um método
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}
