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
            char userLetter = ticTacToe.ChooseLetter();
            ticTacToe.Showboard(board);
            int userMove = ticTacToe.GetUserMove(board);
            ticTacToe.MakeAMove(board, userMove, userLetter);
            ticTacToe.GetWhoStartsFirst();
        }
    }
}
