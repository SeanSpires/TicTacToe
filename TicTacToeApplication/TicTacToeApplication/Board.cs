using System;
using System.Collections.Generic;

namespace TicTacToeApplication
{
    public class Board
    {
        private readonly int BOARD_WIDTH = 3;
        private readonly int BOARD_HEIGHT = 3;

        
        private readonly string[,] board;
        Dictionary<string,int> gameValues = new Dictionary<string, int> {{"X", 1}, {"O", -1}, {".", 0}};

        
        public Board()
        {
            board = new string[BOARD_WIDTH,BOARD_HEIGHT];
            setUpBoard();
        }

        public Board(int width, int height)
        {
            
        }

        public void setUpBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    updateBoard(row, col, ".");
                }
            }
           
        }

        public void updateBoard(int i,int j,string symbol)
        {
            board[i, j] = symbol;
        }


        public string checkForWin()
        {
            var sum = 0;


            //check if a row has a winning condition 
            for (int i = 0; i < board.GetLength(0); i++)
            {
                sum = 0;
                
                for (int j = 0; j <  board.GetLength(1); j++)
                {
                    sum = sum + gameValues[board[i,j]];
                }

                if (sum == board.GetLength(0))
                {
                    return "X";
                }

                if (sum == -board.GetLength(0))
                {
                    return "O";
                }
                
                

            }
    
            //check if a col has a winning condition
            
            for (int j = 0; j < board.GetLength(1); j++)
            {
                sum = 0;
                
                for (int i = 0; i <  board.GetLength(0); i++)
                {
                    sum = sum + gameValues[board[j, i]];
                }
                
                if (sum == board.GetLength(1))
                {
                    return "X";
                }

                if (sum == -board.GetLength(1))
                {
                    return "O";
                }
            }

            //check if a diagonal has a winning condition
            sum = 0;
            for (int i = 0; i < Math.Min(BOARD_WIDTH,BOARD_HEIGHT); i++)
            {
                sum += gameValues[board[i, i]];
            }

            if (sum == Math.Min(BOARD_WIDTH,BOARD_HEIGHT))
            {
                return "X";
            }

            if (sum == -Math.Min(BOARD_WIDTH, BOARD_HEIGHT))
            {
                return "O";
            }

            
            //check other diagonal
            sum = 0;
            
            for (int i = 0 ; i  < Math.Min(BOARD_WIDTH, BOARD_HEIGHT); i++)
            {
                sum += gameValues[board[BOARD_WIDTH - 1 - i, i]];
            }

            if (sum == Math.Min(BOARD_WIDTH,BOARD_HEIGHT))
            {
                return "X";
            }

            if (sum == -Math.Min(BOARD_WIDTH, BOARD_HEIGHT))
            {
                return "O";
            }

            return ".";

        }

        public void displayBoard()
        {
            for (var i = 0; i < board.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (var j = 0; j < board.GetLength(1); j++)
                {
                    
                    if (board[i,j] == ".")
                    {
                        Console.Write(". ");
                    }
                    else
                    {
                      Console.Write(board[i,j] + " ");  
                    }

                }
            }
            Console.WriteLine("\n");
        }

        public string getBoardElement(int i, int j)
        {
            return this.board[i,j];
        }


    }

}