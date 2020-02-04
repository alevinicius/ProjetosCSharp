using System;
using System.Collections.Generic;

using Ex04.Entities;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));
            
            //RemoveAll recebendo como parâmetro um Predicate
            //Poderia ser uma função lambda
            list.RemoveAll(ProductTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //O Predicate é uma função que recebe um objeto
        //e devolve um booleano, pode substituir
        //funções lambda
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
