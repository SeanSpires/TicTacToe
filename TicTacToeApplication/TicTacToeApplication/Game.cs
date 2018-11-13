
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TicTacToeApplication
{
    public class Game
    {
        private Board board = new Board();
        private List<Player> players = new List<Player>();
        
        public void start(int numberOfPlayers)
        {
            
            while (true)
            {
                var playerPlaying = 0;
                Console.WriteLine("Its your turn player " + players[playerPlaying].getPlayerNumber() + ".");
                    Console.Write("Enter in the coordinates of your next move in the following format <row> <col>");
                    string[] userPlay = Console.ReadLine().Split(' ');
                    
   
            }
        }
        
        public void setPlayers(int numberOfPlayers)
        {
            for (int i = 0; i <= numberOfPlayers; i++)
            {
                var player = new Player();
                
                player.setPlayerNumber(i);
                player.setPlayerSymbol(i);
                
                players.Add(player);
            }
            
        }
        
        public checkForValidMove(string[])
    }
}