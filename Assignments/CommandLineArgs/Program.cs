using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;

namespace CommandLineArgs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = args.Length;

            if (!int.TryParse(args[0], out int firstNumber))
            {
                Console.WriteLine($"Invalid Input: {args[0]}");
            }
            int max = firstNumber;
            int min = firstNumber;
            sum = firstNumber;

            for (int i = 1; i < args.Length; i++)
            {
                if (!int.TryParse(args[i], out int number))
                {
                    Console.WriteLine($"Invalid Input: {args[i]}");
                }
                sum = sum + number;

                if (number > max)
                    max = number;
                if (number < min)
                    min = number;
            }

            double average = sum / count;

            Console.WriteLine($"Total numbers are {count}");
            Console.WriteLine($"Sum of all Numbers are {sum}");
            Console.WriteLine($"Average of all Numbers are {average}");
            Console.WriteLine($"{max} is the Maximum number");
            Console.WriteLine($"{min} is the Minimum number");
        }
    }
}
