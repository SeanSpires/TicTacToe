using System;

namespace TicTacToeApplication
{
    public class Render : IRender
    {
        public static void DisplayBoard(IBoard board)
        {
            var playField = board.GetPlayField();
            
            for (var row = 0; row < board.GetBoardWidth(); row++)
            {
                Console.Write("\n");
                for (var col = 0; col < board.GetBoardHeight(); col++)
                {
                    Console.Write(playField[row,col] + " ");   
                    
                }
            }
            Console.Write("\n");
        }

        void IRender.DisplayNumberOfPlayersError()
        {
            DisplayNumberOfPlayersError();
        }

        void IRender.DisplayStartTurn(Player player)
        {
            DisplayStartTurn(player);
        }

        void IRender.DisplayBoard(IBoard board)
        {
            DisplayBoard(board);
        }

        public static void DisplayNumberOfPlayersError()
        {
            Console.WriteLine("Invalid number of players entered, please enter a valid number");
        }

        public static void DisplayStartTurn(Player player)
        {
            
        }
    }
}