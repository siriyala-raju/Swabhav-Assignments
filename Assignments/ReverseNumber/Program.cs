using System.Globalization;

namespace P1_ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int input = int.Parse(Console.ReadLine());
            int original = input;
            int reversed = 0;

            while (input > 0)
            {
                int lastDigit = input % 10;
                reversed = reversed * 10 + lastDigit;
                input = input / 10;
            }
            Console.WriteLine($"Reverse of {original} is {reversed}");
        }
    }
}
