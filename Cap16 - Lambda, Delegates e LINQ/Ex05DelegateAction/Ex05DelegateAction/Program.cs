using System;
using System.Collections.Generic;

using Ex05.Entities;

namespace Ex05
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


            //Action pode ser usado atribuindo uma 
            //função Lambda. Ex:
            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            //Ou pode ser usado atribuindo um 
            //método estático. Ex:
            act = UpdatePrice;            

            list.ForEach(act);
            //ao invés do Act, poderia ser usado a função  Lambda ou o UpdatePRice

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
