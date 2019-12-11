using System;
using Enum_01.Entities;
using Enum_01.Entities.Enums;

namespace Enum_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine();
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
