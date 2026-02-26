namespace P2_Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int input = int.Parse(Console.ReadLine());
            int original = input;
            int length = 0;
            int sum = 0;

            int temp = input;
            while (temp > 0)
            {
                length++;
                temp = temp / 10;
            }

            temp = original;
            while (temp > 0)
            {
                int lastDigit = temp % 10;
                sum = sum + (int)Math.Pow(lastDigit, length);
                temp = temp / 10;
            }

            if (sum == original)
            {
                Console.WriteLine($"{original} is an Armstrong Number");
            }
            else
            {
                Console.WriteLine($"{original} is not an Armstrong Number");
            }
        }
    }
}
