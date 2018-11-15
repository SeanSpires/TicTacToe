using System;
using System.Collections.Generic;

namespace TicTacToeApplication
{
    public class Board
    {
        private static int BOARD_WIDTH;
        private static int BOARD_HEIGHT;
        private const string EMPTY_SYMBOL = ".";
        private readonly string[,] playField;
        
        public Board(int size)
        {
           BOARD_WIDTH = size;
           BOARD_HEIGHT = size;
           playField = new string[BOARD_WIDTH ,BOARD_HEIGHT];
           setUpBoard();

        }

        public void setUpBoard()
        {
            for (int row = 1; row <= BOARD_WIDTH; row++)
            {
                for (int col = 1; col <= BOARD_HEIGHT; col++)
                {
                    updateBoard(row, col, ".");
                }
            }
           
        }

        public void updateBoard(int row,int col,string symbol)
        {
            playField[row - 1, col - 1] = symbol;
        }



        public string getBoardElement(int row, int col)
        {
            return this.playField[row,col];
        }

        public string[,] getPlayField()
        {
            return playField;
        }

        public static int getBoardHeight()
        {
            return BOARD_HEIGHT;
        }

        public static int getBoardWidth()
        {
            return BOARD_WIDTH;
        }

        public static string getEmptySymbol()
        {
            return EMPTY_SYMBOL;
        }

    }

}