using System;
using System.Collections.Generic;

namespace TicTacToeApplication
{
    public class Board : IBoard
    {
        private static int BOARD_WIDTH;
        private static int BOARD_HEIGHT;
        private const string EMPTY_SYMBOL = ".";
        private readonly string[,] playField;
        
        public Board(int size)
        {
           SetGridSize(size);
           playField = new string[BOARD_WIDTH ,BOARD_HEIGHT];
           SetUpBoard();

        }

        private void SetUpBoard()
        {
            for (var row = 1; row <= BOARD_WIDTH; row++)
            {
                for (int col = 1; col <= BOARD_HEIGHT; col++)
                {
                    UpdateBoard(row, col, ".");
                }
            }
           
        }

        public void UpdateBoard(int row,int col,string symbol)
        {
            playField[row - 1, col - 1] = symbol;
        }



        public string GetBoardElement(int row, int col)
        {
            return playField[row,col];
        }

        public string[,] GetPlayField()
        {
            return playField;
        }

        public int GetBoardHeight()
        {
            return BOARD_HEIGHT;
        }

        public int GetBoardWidth()
        {
            return BOARD_WIDTH;
        }

        public string GetEmptySymbol()
        {
            return EMPTY_SYMBOL;
        }

        private void SetGridSize(int size)
        {
            if (size < 2)
            {
                BOARD_WIDTH = 1;
                BOARD_HEIGHT = 1;
            }
            else
            {
                BOARD_WIDTH = size;
                BOARD_HEIGHT = size;          
            }
        }

    }

}