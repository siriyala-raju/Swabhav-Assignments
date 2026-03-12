namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "Laptop", 50000, 10);
            Product p2 = new Product(2, "Mobile", 20000, 5);

            p1.Display();
            p2.Display();
        }
    }
}
