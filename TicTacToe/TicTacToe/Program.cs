namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToeFacade game = new TicTacToeFacade("Raju", "Arjun");

            Console.WriteLine("Tic Tac Toe - Facade Pattern");
            Console.WriteLine("Player 1: Raju (X)  Player 2: Arjun (O)");
            Console.WriteLine("Enter row and column (0-2)\n");

            while (true)
            {
                Console.Write("Enter row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter col: ");
                int col = Convert.ToInt32(Console.ReadLine());

                game.MakeMove(row, col);

                if (game.IsGameOver)
                {
                    Console.Write("\nPlay again? (yes/no): ");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                        game.ResetGame();
                    else
                        break;
                }
            }
        }
    }
}