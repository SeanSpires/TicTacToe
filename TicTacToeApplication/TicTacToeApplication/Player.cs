using System;

namespace TicTacToeApplication
{
    public class Player
    {
        private string symbol;
        private int playerNumber;
        private bool isPlayerTurn;

        public void setPlayerNumber(int playerNumber)
        {
            this.playerNumber = playerNumber;
        }

        public void setPlayerSymbol(int playerNumber)
        {
            this.symbol = playerNumber % 2 == 0 ? "X" : "O";
        }

        public void setPlayerTurn()
        {
            isPlayerTurn = isPlayerTurn == false;
        }

        public int getPlayerNumber()
        {
            return this.playerNumber;
            
        }

        public string getPlayerSymbol()
        {
            return this.symbol;
        }
    }
}