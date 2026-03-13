namespace Params_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void ShowNumbers(params int[] numbers)
            {
                foreach (int n in numbers)
                {
                    Console.WriteLine($"Number: {n}");
                }
            }

            {
                ShowNumbers(10, 20, 30, 40);
            }
        }
    }
}
