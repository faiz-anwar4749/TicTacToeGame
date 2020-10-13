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
            char userLetterFinal = char.ToUpper(Console.ReadLine()[0]);
            if (userLetterFinal != 'X' || userLetterFinal != 'O')
            {
                while(userLetterFinal != 'X' && userLetterFinal != 'O')
                {
                    Console.WriteLine("Invalid input. Please Enter X or O: ");
                    userLetterFinal = Console.ReadLine()[0];
                }      
            }
            Console.WriteLine($"You Chose {userLetterFinal}");
            return userLetterFinal;    
        }
        public void Showboard(char[] board)
        {
            Console.WriteLine("  " + board[1] + "|" + board [2] + "|" + board[3]);
            Console.WriteLine("-----------");
            Console.WriteLine("  " + board[4] + "|" + board[5] + "|" + board[6]);
            Console.WriteLine("-----------");
            Console.WriteLine("  " + board[7] + "|" + board[8] + "|" + board[9]);
        }
        public int GetUserMove(char[] board)
        {
           while(true)
           {
                Console.WriteLine("Enter your next move(1-9): ");
                int index = Convert.ToInt32(Console.ReadLine());
                if (index >= 1 && index <= 9)
                {
                    Console.WriteLine($"You chose {index}");
                }
                else
                {
                    Console.WriteLine("Invalid move. Please try again");
                }
                return index;
           }
        }
        public bool IsSpaceFree(char[] board, int index)
        {
            return board[index] == ' ';
        }
    }
}
