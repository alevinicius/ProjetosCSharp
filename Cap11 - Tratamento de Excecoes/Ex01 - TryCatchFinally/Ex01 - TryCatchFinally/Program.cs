using System;

namespace Ex01___TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
                Console.WriteLine("Boa noite!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é permitido divisão por zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro de formação, digite um número inteiro");
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Até mais");
            }
        }
    }
}
