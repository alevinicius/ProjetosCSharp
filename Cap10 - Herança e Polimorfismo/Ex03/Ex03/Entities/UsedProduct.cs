﻿using System;
using System.Globalization;

namespace Ex03.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public sealed override string PriceTag()
        {
            return
                Name +
                " (used) $" +
                Price.ToString("F2", CultureInfo.InvariantCulture) +
                " (Manufacture date: " +
                ManufactureDate.ToString("dd/MM/yyyy") +
                ")";
        }
    }
}
