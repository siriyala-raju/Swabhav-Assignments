using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Discount_Calculator
{
    internal class Book
    {
        public string Title;
        public string Author;
        public double Price;
        public bool IsBestseller;

        public Book(string title, string author, double price, bool isBestseller)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
            this.IsBestseller = isBestseller;
        }

        public double DiscountedPrice()
        {
            double finalPrice = Price;

            if (IsBestseller)
            {
                Console.WriteLine($"'{Title}' is a bestseller. Applying 10% discount.");
                finalPrice = finalPrice - (finalPrice * 0.10);
            }

            if (Price > 500)
            {
                Console.WriteLine($"'{Title}' is priced over 500. Applying additional 5% discount.");
                finalPrice = finalPrice - (finalPrice * 0.05);
            }
            return finalPrice;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Original Price: ${Price}");

            double discounted = DiscountedPrice();
            Console.WriteLine($"Final Discounted Price: ${discounted}");
        }
    }
}
