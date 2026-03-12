using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp
{
    internal class Product
    {
        public int id;
        public string name;
        public double price;
        public double discountPercentage;

        public Product(int id, string name, double price, double discountPercentage)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.discountPercentage = discountPercentage;
        }

        public double DiscountedPrice()
        {
            double discountAmount = price * discountPercentage / 100;
            return price - discountAmount;
        }

        public void Display()
        {
            Console.WriteLine($"Product ID: {id}");
            Console.WriteLine($"Product Name: {name}");
            Console.WriteLine($"Actual Price: {price}");
            Console.WriteLine($"Discount Percentage: {discountPercentage} %");
            Console.WriteLine($"Price After Discount: {DiscountedPrice()}");
        }
    }
}
