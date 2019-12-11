using System;

namespace DateTime_ISO_8601 {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = DateTime.Parse("2019-09-23 12:00:00");
            DateTime d2 = DateTime.Parse("2019-09-23T12:00:00Z");

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("Kind: " + d1.Kind);
            Console.WriteLine("ToLocalTime: " + d1.ToLocalTime());
            Console.WriteLine("ToUniversalTime: " + d1.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("Kind: " + d2.Kind);
            Console.WriteLine("ToLocalTime: " + d2.ToLocalTime());
            Console.WriteLine("ToUniversalTime: " + d2.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
