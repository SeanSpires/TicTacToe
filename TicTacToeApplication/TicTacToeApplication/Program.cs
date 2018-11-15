using System;
using System.Text.RegularExpressions;

namespace TicTacToeApplication
{
    internal class TicTacToe
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many players will be playing? ");
            var userInput = Console.ReadLine();
            Game game = new Game(int.Parse(userInput));
            game.start();
        }
    }
}