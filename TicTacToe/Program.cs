using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game.");
            TicTacToeGame ticTacToe = new TicTacToeGame();
            char[] board = TicTacToeGame.MakeBoard();
        }
    }
}
