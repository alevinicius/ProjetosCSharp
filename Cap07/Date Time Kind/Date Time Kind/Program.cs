using System;

namespace Date_Time_Kind {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = new DateTime(2000, 08, 15, 13, 05, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 08, 15, 13, 05, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 08, 15, 13, 05, 58, DateTimeKind.Unspecified);

            Console.WriteLine("Local: "+ d1);
            Console.WriteLine("Utc: "+ d2);
            Console.WriteLine("Unspecified: "+ d3);

            Console.WriteLine();

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1.Kind: " + d1.Kind);
            Console.WriteLine("d1.ToLocalTime: " + d1.ToLocalTime());
            Console.WriteLine("d1.ToUniversalTime: " + d1.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2.Kind: " + d2.Kind);
            Console.WriteLine("d2.ToLocalTime: " + d2.ToLocalTime());
            Console.WriteLine("d2.ToUniversalTime: " + d2.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3.Kind: " + d3.Kind);
            Console.WriteLine("d3.ToLocalTime: " + d3.ToLocalTime());
            Console.WriteLine("d3.ToUniversalTime: " + d3.ToUniversalTime());

        }
    }
}
