namespace In_And_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void AddNumbers(in int a, in int b, out int result)
            {
                result = a + b;
            }

            {
                int x = 10;
                int y = 20;
                int sum;

                AddNumbers(x, y, out sum);

                Console.WriteLine($"Sum = {sum}");
            }
        }
    }
}
