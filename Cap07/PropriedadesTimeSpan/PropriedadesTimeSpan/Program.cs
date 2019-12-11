using System;

namespace PropriedadesTimeSpan {
    class Program {
        static void Main(string[] args) {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine(); Console.WriteLine();

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);

            Console.WriteLine("01) Days: " + t.Days);
            Console.WriteLine("02) Hours: " + t.Hours);
            Console.WriteLine("03) Minutes: " + t.Minutes);
            Console.WriteLine("04) Seconds: " + t.Seconds);
            Console.WriteLine("05) Milliseconds: " + t.Milliseconds);
            Console.WriteLine("06) Ticks: " + t.Ticks);

            Console.WriteLine();

            Console.WriteLine("07) TotalDays: " + t.TotalDays);
            Console.WriteLine("08) TotalHours: " + t.TotalHours);
            Console.WriteLine("09) TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("10) TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("11) TotalMilliseconds: " + t.TotalMilliseconds);
            
        }
    }
}
