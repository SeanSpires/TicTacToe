using System;

namespace TicTacToeApplication
{
    public class Render
    {
        public static void displayBoard(Board board)
        {
            var playField = board.getPlayField();
            
            for (var row = 0; row < Board.getBoardWidth(); row++)
            {
                Console.Write("\n");
                for (var cols = 0; cols < Board.getBoardHeight(); cols++)
                {
                    Console.Write(playField[row,cols] + " ");   
                    
                }
            }
            Console.Write("\n");
        }
    }
}