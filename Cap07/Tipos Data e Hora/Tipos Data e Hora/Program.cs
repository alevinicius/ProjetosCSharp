using System;
using System.Globalization;

namespace Tipos_Data_e_Hora {
    class Program {
        static void Main(string[] args) {
                        DateTime d1 = new DateTime(2019, 11, 26);
            DateTime d2 = new DateTime(2019, 11, 26, 22, 17, 03);
            DateTime d3 = new DateTime(2019, 11, 26, 22, 17, 03, 500);
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;
            
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            DateTime d7 = DateTime.Parse("2000-08-15"); Console.WriteLine(d7);
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58"); Console.WriteLine(d8);
            DateTime d9 = DateTime.Parse("23/09/1991 13:05:58"); Console.WriteLine(d9);

            Console.WriteLine(); Console.WriteLine();

            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("23/09/1991 22:20:43", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);



        }
    }
}
