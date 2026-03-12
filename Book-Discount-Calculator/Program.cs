namespace Book_Discount_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("The Power of Habit", "Charles Duhigg", 600, true);
            Book b2 = new Book("C# Programming", "Jane Doe", 450, false);

            b1.Display();
            b2.Display();
        }
    }
}
