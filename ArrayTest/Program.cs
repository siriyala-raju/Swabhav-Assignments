using System;

namespace ArrayTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Raju", "Murugeesh", "Kamal", "Rohan" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Index: {i}  Value: {names[i]}");
            }

            foreach (string name in names)
            {
                Console.WriteLine($"Value: {name}");
            }
        }
    }
}