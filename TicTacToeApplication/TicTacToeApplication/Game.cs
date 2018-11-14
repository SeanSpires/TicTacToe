
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace TicTacToeApplication
{
    public class Game
    {
        private Board board = new Board();
        private List<Player> players = new List<Player>();

        public Game(int numberOfPlayers)
        {
            setPlayers(numberOfPlayers);
        }

        public void start()
        {
            var playerPlaying = 0;
            board.displayBoard();

            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Its your turn player " + players[playerPlaying].getPlayerNumber() + ".");
                Console.WriteLine("Your symbol is " + players[playerPlaying].getPlayerSymbol());

                while (true)
                {
                    Console.WriteLine("Enter in the coordinates of your next move in the following format <row> <col>");
                    var userPlay = Console.ReadLine();

                    if (checkForValidMove(userPlay))
                    {
                        var coordinates = userPlay.Split(' ').Select(int.Parse).ToList();
                        board.updateBoard(coordinates[0], coordinates[1], players[playerPlaying].getPlayerSymbol());
                        board.displayBoard();
                        var gameWon = board.checkForWin();

                        if (gameWon == "X")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Player 0 has won the game");
                            return;
                        }

                        if (gameWon == "O")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Player 1 has won the game");
                            return;
                        }

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid move, please enter a valid move");

                    }


                }

                playerPlaying++;

                if (playerPlaying >= players.Count)
                {
                    playerPlaying = 0;
                }
            }
        }

        public void setPlayers(int numberOfPlayers)
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
                var match = Regex.Match(userPlay, @"^[0-2] [0-2]$");

                if (!match.Success)
                {
                    return false;
                }

                else if (board.getBoardElement(coordinates[0], coordinates[1]).Trim() != "empty")
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
    }
}