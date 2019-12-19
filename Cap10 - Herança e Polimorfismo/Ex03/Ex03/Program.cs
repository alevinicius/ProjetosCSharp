using System;
using System.Collections.Generic;
using System.Globalization;

using Ex03.Entities;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.Write("Common, used or imported (c/u/i)? ");
                string cui = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product;
                switch (cui[0])
                {
                    default:
                        product = new Product(name, price);
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        product = new UsedProduct(name, price, manufactureDate);
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        product = new ImportedProduct(name, price, customsFee);
                        break;
                }
                products.Add(product);
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in products) 
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
