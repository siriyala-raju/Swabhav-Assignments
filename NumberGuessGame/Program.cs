using System;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;

            do
            {
                Random random = new Random();
                int number = random.Next(1, 101);
                int tries = 0;

                while (true)
                {
                    Console.Write("Enter a number between 1-100: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int guess))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    tries++;

                    if (guess > number)
                    {
                        Console.WriteLine("Sorry, Too High");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Sorry, Too Low");
                    }
                    else
                    {
                        Console.WriteLine("You Won!");
                        break;
                    }
                }

                Console.WriteLine($"You won in {tries} tries.");

                Console.Write("Do you want to play again? (yes/no): ");
                choice = Console.ReadLine().ToLower();

            } while (choice == "yes");

            Console.WriteLine("Thank you for playing!");
        }
    }
}