using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DateTimeExtensions (method ElapsedTime)");
            Console.WriteLine();
            DateTime dt = new DateTime(2020, 01, 27, 21, 28, 45);
            Console.WriteLine(dt.ElapsedTime());

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            Console.WriteLine("StringExtensions (method Cut)");
            Console.WriteLine();
            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
            Console.WriteLine(s1.Cut(25));
            Console.WriteLine();
        }
    }
}
