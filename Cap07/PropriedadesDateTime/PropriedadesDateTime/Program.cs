using System;


namespace PropriedadesDateTime {
    class Program {
        static void Main(string[] args) {
            DateTime d = new DateTime(2019, 11, 27, 21, 05, 20, 500);

            Console.WriteLine("ToLongDateString: " + d.ToLongDateString());
            Console.WriteLine("ToLongTimeString: " + d.ToLongTimeString());
            Console.WriteLine("ToShortDateString: " + d.ToShortDateString());
            Console.WriteLine("ToShortTimeString: " + d.ToShortTimeString());
            Console.WriteLine("ToString('yyyy-MM-dd HH:mm:ss'): " + d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("ToString('yyyy-MM-dd HH:mm:ss.fff'): " + d.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("01) Date: " + d.Date);
            Console.WriteLine("02) Day: " + d.Day);
            Console.WriteLine("03) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("04) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("05) Hour: " + d.Hour);
            Console.WriteLine("06) Kind: " + d.Kind);
            Console.WriteLine("07) Millisecond: " + d.Millisecond);
            Console.WriteLine("08) Minute: " + d.Minute);
            Console.WriteLine("09) Second: " + d.Second);
            Console.WriteLine("10) Ticks: " + d.Ticks);
            Console.WriteLine("11) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("12) Year: " + d.Year);
            Console.WriteLine("13) Month: " + d.Month);
        }
    }
}
