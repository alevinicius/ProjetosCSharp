using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex07Linq01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define the query expression
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0) //Somente numeros pares
                .Select(x => x * 10);   //Multiplica resultado por 10

            //Execute de query
            foreach (int x in result)
            {
                Console.WriteLine(x); 
                //Resultado vai ser 20 e 40
            }
        }
    }
}
