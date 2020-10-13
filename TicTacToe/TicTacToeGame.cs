using System;
using System.Collections.Generic;
using System.Text;
namespace TicTacToe
{
    public class TicTacToeGame
    {
        public static char[] MakeBoard()
        {
            char[] board = new char[10];
            for(int i=1; i<board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
    }
}
