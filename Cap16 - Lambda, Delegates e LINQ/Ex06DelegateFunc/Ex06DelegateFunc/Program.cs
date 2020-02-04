using System;
using System.Linq;
using System.Collections.Generic;

using Ex06.Entities;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HDCase", 80.90));

            //Posso associar um método normal ou expressão lambda

            //método 
            Func<Product, string> func = NameUpper;

            //lambda
            func = p => p.Name.ToUpper();

            //O func do select poderia ser substituido por uma expressao lambda
            List<string> result = list.Select(func).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
