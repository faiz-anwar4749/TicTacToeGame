using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
namespace TicTacToe
{
    public class TicTacToeGame
    {
        public enum Player { USER, COMPUTER };
        
        public char[] MakeBoard()
        {
            char[] board = new char[10];
            for(int i=1; i< board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public char ChooseLetter()
        {
            Console.Write("Choose your letter,(either X or O): ");
            string userLetter = Console.ReadLine();
            char userLetterFinal = char.ToUpper(userLetter[0]);
            if (userLetterFinal != 'X' || userLetterFinal != 'O')
            {
                while (userLetterFinal != 'X' && userLetterFinal != 'O')
                {
                    Console.WriteLine("Invalid input. Please Enter X or O: ");
                    userLetter = Console.ReadLine();
                }
            }
            Console.WriteLine($"You Chose {userLetterFinal}");
            return userLetterFinal;    
        }
    }
}
