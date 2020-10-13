using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game.");
            TicTacToeGame ticTacToe = new TicTacToeGame();
            char[] board = ticTacToe.MakeBoard();
            ticTacToe.ChooseLetter();
            ticTacToe.Showboard(board);
            int userMove = ticTacToe.GetUserMove(board);
        }
    }
}
