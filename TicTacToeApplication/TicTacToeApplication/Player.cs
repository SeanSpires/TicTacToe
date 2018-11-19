using System;
using System.Linq;

namespace TicTacToeApplication
{
    public class Player
    {
        private string symbol;
        private int playerNumber;

        public Player(int playerNumber)
        {
            SetPlayerNumber(playerNumber);
            SetPlayerSymbol(playerNumber);
        }


        private void SetPlayerNumber(int playerNumber)
        {
            this.playerNumber = playerNumber + 1;
        }

        private void SetPlayerSymbol(int playerNumber)
        {
            symbol = playerNumber % 2 == 0 ? "X" : "O";
        }

        public int GetPlayerNumber()
        {
            return playerNumber;
            
        }

        public string GetPlayerSymbol()
        {
            return symbol;
        }

        public void MakeMove(Game game, string userPlay)
        {
            var coordinates = userPlay.Split(',').Select(int.Parse).ToList();
            Console.WriteLine("Move accepted, here's the current board:");                
            game.UpdatePlayField(coordinates[0], coordinates[1]);
            
        }
    }
}