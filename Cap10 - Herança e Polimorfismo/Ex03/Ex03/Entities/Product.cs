﻿using System.Globalization;

namespace Ex03.Entities
{
    class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $" + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
