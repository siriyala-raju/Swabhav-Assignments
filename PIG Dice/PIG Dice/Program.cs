namespace PIG_Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int totalScore = 0;
            int turn = 1;

            Console.WriteLine("Lets Play PIG!");

            while (totalScore < 20)
            {
                Console.WriteLine($"Turn {turn}");
                int turnScore = 0;

                while (true)
                {
                    Console.Write("Roll or Hold (r/h): ");
                    char choice = Console.ReadLine().ToLower()[0];

                    if (choice == 'r')
                    {
                        int die = random.Next(1, 7);
                        Console.WriteLine($"Dice {die}");

                        if (die == 1)
                        {
                            turnScore = 0;
                            Console.WriteLine("Turn Over. No Score");
                            break;
                        }
                        else
                        {
                            turnScore += die;
                        }
                    }
                    else if (choice == 'h')
                    {
                        totalScore += turnScore;
                        Console.WriteLine($"Score for turn: {turnScore}");
                        Console.WriteLine($"Total Score: {totalScore}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input Entered");
                    }
                }
                turn++;
            }
            Console.WriteLine($"You finished in {turn - 1} turns!");
            Console.WriteLine($"Game Over!!!");
        }
    }
}
