using System;
using Ex03.Services;

namespace Ex03
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //Usando multicast delegate eu posso ir adicionando métodos 
            //a um delegate e depois executá-los em sequência            

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op(a, b);
        }
    }
}
