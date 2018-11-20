using System;
using System.Text.RegularExpressions;

namespace TicTacToeApplication
{
    internal class TicTacToe
    {
        public static void Main(string[] args)
        {
            var gridSize = 1;
            var numberOfPlayers = 1;
            var inputIsValid = false;
            
            while (!inputIsValid)
            {
                Console.WriteLine("How many players will be playing?");
                var userInput = Console.ReadLine();
                
                if (Validator.ValidateNumberOfPlayers(userInput))
                {
                    inputIsValid = true;
                    numberOfPlayers = int.Parse(userInput);
                }
                else
                {
                    Render.DisplayNumberOfPlayersError();
                }
            }

            inputIsValid = false;
            
            while (!inputIsValid)
            {
                Console.WriteLine("what grid size do you want?");
                var userInput = Console.ReadLine();
                if (int.TryParse(userInput, out var output))
                {
                    gridSize = output;
                    inputIsValid = true;
                }
            }


            var game = new Game(numberOfPlayers,gridSize);
            game.Start();
        }
    }
}