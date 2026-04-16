using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        private char[,] grid = new char [3, 3];

        public Board()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    grid[i, j] = '-';
        }

        public bool PlaceMark(int row, int col, char mark)
        {
            if (grid[row, col] == '-')
            {
                grid[row, col] = mark;
                return true;
            }
            return false;
        }

        public char GetCell(int row, int col)
        {
            return grid[row, col];
        }

        public void Display()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3;j++)
                    Console.Write(grid[i,j] + " ");
                Console.WriteLine();
            }
        }

        public void Reset()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    grid[i, j] = '-';
        }
    }
}
