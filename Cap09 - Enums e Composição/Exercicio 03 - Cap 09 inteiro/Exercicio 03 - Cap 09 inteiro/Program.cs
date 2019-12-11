using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_03.Entities;
using Exercicio_03.Entities.Enums;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime moment = DateTime.Now;
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);

            Console.WriteLine();

            Console.WriteLine("Enter order data: ");
            Console.Write($"Status (" +
                $"{OrderStatus.PendingPayment}, " +
                $"{OrderStatus.Processing}, " +
                $"{OrderStatus.Shipped} or " +
                $"{OrderStatus.Delivered}): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(moment, status, client);
            Console.WriteLine();

            int opcao = 1;
            int count = 1;            
            while(opcao == 1)
            {
                Console.WriteLine($"Enter #{count} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem(quantity, product.Price, product);

                order.AddItem(item);
                Console.WriteLine();
                Console.WriteLine("1 - Include a new product item");
                Console.WriteLine("2 - Finish order");
                Console.Write("Select the option (1 or 2): ");
                opcao = int.Parse(Console.ReadLine());
                count++;
                Console.WriteLine();
            }
            
            Console.WriteLine(order);
  


        }
    }
}
