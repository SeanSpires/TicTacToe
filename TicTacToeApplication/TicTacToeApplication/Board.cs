using System;

namespace TicTacToeApplication
{
    public class Board
    {
        private string[,] board;
//        private Player player;
        
        public Board()
        {
            board = new string[2,2];

            

        }

        public void initalizeBoard()
        {
            for (int row = 0; row <= 2; row++)
            {
                for (int col = 0; col <= 2; col++)
                {
                    updateBoard(row, col, "empty");
                }
            }
        }

        public string updateBoard(int i,int j,string symbol)
        {
            board[i, j] = symbol;
            return "asda";
        }


        public void checkForWin(Player player)
        {
            
        }

        public void displayBoard()
        {
            
        }
        


    }

}