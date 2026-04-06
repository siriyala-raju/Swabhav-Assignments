namespace P4_PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int input = int.Parse(Console.ReadLine());

            while (input <= 1)
            {
                Console.WriteLine($"{input} is not a Prime Number");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{input} is a Prime Number");
            }
            else
            {
                Console.WriteLine($"{input} is not a Prime Number");
            }
        }
    }
}
