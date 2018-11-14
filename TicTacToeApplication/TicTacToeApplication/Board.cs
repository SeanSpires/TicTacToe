using System;
using System.Collections.Generic;

namespace TicTacToeApplication
{
    public class Board
    {
        private readonly string[,] board;
        Dictionary<string,int> gameValues = new Dictionary<string, int> {{"X", 1}, {"O", -1}, {"empty", 0}};

        
        public Board()
        {
            board = new string[3,3];
            setUpBoard();
        }

        public void setUpBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    updateBoard(row, col, "empty");
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

            for (int i = 0; i < board.GetLength(0); i++)
            {
                sum = 0;
                
                for (int j = i; j < board.GetLength(1); j++)
                {
                    sum = sum + gameValues[board[i,j]];
                }

                if (sum == board.GetLength(0))
                {
                    return "X";
                }

                if (sum == -board.GetLength(1))
                {
                    return "O";
                }
                
            }
            
            //check other diagonal
            for (int i = board.GetLength(0) - 1; i >= 0; i--)
            {
                sum = 0;
                
                for (int j = i; j < board.GetLength(1); j++)
                {
                   sum = sum + gameValues[board[i, j]];
                }
                
            }

            if (sum == board.GetLength(0))
            {
                return "X";
            }    

            if (sum == -board.GetLength(1))
            {
                return "O";
            }
            else
            {
                return "empty";   
            }

            

        }

        public void displayBoard()
        {
            for (var i = 0; i < board.GetLength(0); i++)
            {
                Console.WriteLine(" ");
                for (var j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i,j] == "empty")
                    {
                        Console.Write("empty ");
                    }
                    else
                    {
                      Console.Write(board[i,j] + " ");  
                    }

                }
            }
        }

        public string getBoardElement(int i, int j)
        {
            Console.WriteLine(board[i,j]);
            return this.board[i,j];
        }


    }

}