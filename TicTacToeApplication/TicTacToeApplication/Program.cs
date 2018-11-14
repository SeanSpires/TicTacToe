using System;
using System.Text.RegularExpressions;

namespace TicTacToeApplication
{
    internal class TicTacToe
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("How many players will be playing? ");
                var userInput = Console.ReadLine();

                try
                {
                    var numberOfPlayers = int.Parse(userInput);
                }
                //catch()

            }
        }
    }
}