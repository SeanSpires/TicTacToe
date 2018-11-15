using System;
using System.Collections.Generic;

namespace TicTacToeApplication
{
    public class Board
    {
        private readonly int BOARD_WIDTH = 3;
        private readonly int BOARD_HEIGHT = 3;

        
        private readonly string[,] playField;
        
        
        public Board()
        {
            playField = new string[BOARD_WIDTH,BOARD_HEIGHT];
            setUpBoard();
        }

        public Board(int width, int height)
        {
            
        }

        public void setUpBoard()
        {
            for (int row = 1; row <= 3; row++)
            {
                for (int col = 1; col <= 3; col++)
                {
                    updateBoard(row, col, ".");
                }
            }
           
        }

        public void updateBoard(int i,int j,string symbol)
        {
            playField[i - 1, j - 1] = symbol;
        }

        public void displayBoard()
        {
            for (var i = 0; i < playField.GetLength(0); i++)
            {
                Console.Write("\n");
                for (var j = 0; j < playField.GetLength(1); j++)
                {
                    
                    if (playField[i,j] == ".")
                    {
                        Console.Write(". ");
                    }
                    else
                    {
                      Console.Write(playField[i,j] + " ");  
                    }

                }
            }
            Console.Write("\n");
        }

        public string getBoardElement(int i, int j)
        {
            return this.playField[i,j];
        }

        public string[,] getPlayField()
        {
            return playField;
        }

        

    }

}