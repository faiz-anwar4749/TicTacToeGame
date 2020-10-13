using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public static char[] MakeBoard()
        {
            char[] board = new char[10];
            for(int i=0; i<board.Length;i++)
            {
                board[i] = ' ';
            }
            return board;
        }
    }
}
