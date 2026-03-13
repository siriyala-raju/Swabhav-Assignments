namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "123";
            int number;

            if (int.TryParse(input, out number))
            {
                Console.WriteLine($"Converted number = {number}");
            }
            else
            {
                Console.WriteLine($"'{input}' is not a valid number");
            }
        }
    }
}
