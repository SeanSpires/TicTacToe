using System;
using System.Runtime.InteropServices;
using TicTacToeApplication;

namespace TicTacToeUnitTest
{
    public class MockRender : IRender
    {
        private string[,] printedOutput;


        public void DisplayBoard(IBoard board)
        {
            printedOutput = new string[board.GetBoardWidth(),board.GetBoardHeight()];
            var playField = board.GetPlayField();
            
            for (var row = 0; row < board.GetBoardWidth(); row++)
            {
                for (var col = 0; col < board.GetBoardHeight(); col++)
                {
                    printedOutput[row, col] = playField[row, col];
                }
            }
        }

        public void DisplayNumberOfPlayersError()
        {
           
        }

        public void DisplayStartTurn(Player player)
        {
        }

        public string[,] getPrintedOutput()
        {
            return printedOutput;
        }


    }
}