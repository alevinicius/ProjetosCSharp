using System.Globalization;
namespace Exercicio_03.Entities 
{
    class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public Product Product = new Product();

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public OrderItem(int quantity, double price, Product product) : this(quantity, price)
        {
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return
                $"{Product.Name}, " +
                $"${Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: " +
                $"{Quantity}, Subtotal: " +
                $"${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
