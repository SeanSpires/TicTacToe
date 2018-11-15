
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace TicTacToeApplication
{
    public class Game
    {
        private static Board board = new Board();
        private List<Player> players = new List<Player>();
        private static Dictionary<string,int>  gameValues = new Dictionary<string, int> {{"X", 1}, {"O", -1}, {".", 0}};
        private int playerPlaying = 0;

        public Game(int numberOfPlayers)
        {
            initalizePlayers(numberOfPlayers);
        }

        public void start()
        {
            board.displayBoard();

            while (true)
            {
                Console.WriteLine("Its your turn player " + players[playerPlaying].getPlayerNumber() + ".");
                Console.WriteLine("Your symbol is " + players[playerPlaying].getPlayerSymbol());
                
                while (true)
                {
                    Console.WriteLine("Enter in the coordinates of your next move in the following format <row> <col>");
                    var userPlay = Console.ReadLine();

                    if (checkForValidMove(userPlay))
                    {
                        var coordinates = userPlay.Split(' ').Select(int.Parse).ToList();
                        Console.WriteLine("Move accepted, here's the current board:");
                        updatePlayField(coordinates[0], coordinates[1]);
                        checkIfGameWon(new WinCondition(players[playerPlaying], board));      
                        break;
                    }

                    Console.WriteLine("Invalid move, please enter a valid move");

                }
                nextPlayer();            
            }
        }

        public void initalizePlayers(int numberOfPlayers)
        {
            for (var i = 0; i < numberOfPlayers; i++)
            {
                var player = new Player();

                player.setPlayerNumber(i);
                player.setPlayerSymbol(i);

                players.Add(player);
            }

        }

        private bool checkForValidMove(string userPlay)
        {
            try
            {
                var coordinates = userPlay.Split(' ').Select(int.Parse).ToList();
                var match = Regex.Match(userPlay, @"^[1-3] [1-3]$");

                if (!match.Success)
                {
                    return false;
                }

                else if (board.getBoardElement(coordinates[0] - 1, coordinates[1] - 1) != ".")
                {
                    Console.WriteLine("Those coordinates have already been selected");
                    return false;
                }

                else
                {
                    return true;
                }

            }
            catch (FormatException e)
            {
                return false;
            }
        }


        public void nextPlayer()
        {
            playerPlaying++;

            if (playerPlaying >= players.Count)
            {
                playerPlaying = 0;
            }
        }
        
        public static int calculateGameValues(string symbol)
        {
            return gameValues[symbol];
        }

        public void updatePlayField(int i,int j)
        {
            board.updateBoard(i,j, players[playerPlaying].getPlayerSymbol());
            board.displayBoard();    
        }

        public void checkIfGameWon(WinCondition winCondition)
        {
            if (winCondition.hasPlayerWon())
            {
                Console.WriteLine("Player " + players[playerPlaying].getPlayerNumber() + " has won the game!");
                Environment.Exit(1);
            }    
        }
    }
}