using System;

namespace Structs_e_Nullable {
    class Program {
        static void Main(string[] args) {
            Ponto p;
            p.PX = 10;
            p.PY = 20;
            Console.WriteLine(p);

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            double? x = null;
            double? y = 10.0;
            
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            } else {
                Console.WriteLine("X é nulo");
            }


            if (y.HasValue) {
                Console.WriteLine(y.Value);
            } else {
                Console.WriteLine("Y é nulo");
            }

            Console.WriteLine();
            Console.WriteLine();

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
