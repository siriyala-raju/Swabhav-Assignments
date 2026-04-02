namespace FuncDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> calculateDiscount = price => price > 1000 ? price * 0.15 : price * 0.05;
            Func<double, double, double> calculateFinalPrice = (price, discount) => price - discount;

            Console.Write("Enter product price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            double discount = calculateDiscount(price);
            double finalPrice = calculateFinalPrice(price, discount);

            Console.WriteLine("Price: " + price);
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Final Price: " + finalPrice);
        }
    }
}
