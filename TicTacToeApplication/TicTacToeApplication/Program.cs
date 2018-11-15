using System;
using System.Text.RegularExpressions;

namespace TicTacToeApplication
{
    internal class TicTacToe
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many players will be playing? ");
            var numberOfPlayers = Console.ReadLine();
            Console.WriteLine("what grid size do you want to play with");
            var gridSize = Console.ReadLine();
            Game game = new Game(int.Parse(numberOfPlayers),int.Parse(gridSize));
            game.start();
        }
    }
}