using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeFacade
    {
        private Board board;
        private GameLogic gameLogic;
        private Player player1;
        private Player player2;
        private Player currentPlayer;
        private bool gameOver;

        public TicTacToeFacade(string name1, string name2)
        {
            board = new Board();
            gameLogic = new GameLogic();

            player1 = new Player { Name = name1, Mark = 'X' };
            player2 = new Player { Name = name2, Mark = 'O' };

            currentPlayer = player1;
            gameOver = false;
        }

        public void MakeMove(int row, int col)
        {
            if (gameOver)
            {
                Console.WriteLine("Game is over! Reset to play again.");
                return;
            }

            if (!board.PlaceMark(row, col, currentPlayer.Mark))
            {
                Console.WriteLine("Cell already taken! Try again.");
                return;
            }

            board.Display();

            if (gameLogic.CheckWinner(board, currentPlayer.Mark))
            {
                Console.WriteLine(currentPlayer.Name + " wins!");
                gameOver = true;
                return;
            }

            if (gameLogic.CheckDraw(board))
            {
                Console.WriteLine("It's a draw!");
                gameOver = true;
                return;
            }

            currentPlayer = currentPlayer == player1 ? player2 : player1;
            Console.WriteLine(currentPlayer.Name + "'s turn (" + currentPlayer.Mark + ")");
        }

        public void ResetGame()
        {
            board.Reset();
            currentPlayer = player1;
            gameOver = false;
            Console.WriteLine("Game reset! " + currentPlayer.Name + " starts.");
        }

        public bool IsGameOver
        {
            get { return gameOver; }
        }
    }
}