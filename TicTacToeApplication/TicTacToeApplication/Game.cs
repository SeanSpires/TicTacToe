
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace TicTacToeApplication
{
    public class Game
    {
        private static Board board;
        private readonly List<Player> players = new List<Player>();
        private int playerNumber;
        private Player playerPlaying;
        private bool gameIsFinished;
        private static readonly Dictionary<string,int>  gameValues = new Dictionary<string, int> {{"X", 1}, {"O", -1}
            , {".", 0}};
        
        public Game(int numberOfPlayers,int gridSize)
        {
            InitializePlayers(numberOfPlayers);
            board =  new Board(gridSize);
            gameIsFinished = false;
            playerNumber = 0;
        }

        public void Start()
        {
            Render.DisplayBoard(board);
            
            while (!gameIsFinished)
            {
                playerPlaying = players[playerNumber];
                
                Console.WriteLine("Its your turn player " + playerPlaying.GetPlayerNumber());
                Console.WriteLine("Your symbol is " + playerPlaying.GetPlayerSymbol());
                var moveIsValid = false;
                
                while (!moveIsValid)
                {
                    Console.WriteLine("Enter in the coordinates of your next move in the following format <row>,<col>");
                    var userPlay = Console.ReadLine();
                    var validator = new Validator(board);
                    
                    if (validator.ValidateUserPlay(userPlay))
                    {
                        ProcessUserPlay(userPlay);
                        moveIsValid = true;
                    }

                    else
                    {
                        Console.WriteLine("Invalid move, please enter a valid move");    
                    }
                }
                NextPlayer();            
            }
        }

        private void InitializePlayers(int numberOfPlayers)
        {
            for (var i = 0; i < numberOfPlayers; i++)
            {
                var player = new Player(i);
                players.Add(player);
            }

        }

        private void NextPlayer()
        {
            playerNumber++;

            if (playerNumber >= players.Count)
            {
                playerNumber = 0;
            }
        }
        
        public static int CalculateGameValues(string symbol)
        {
            return gameValues[symbol];
        }

        public void UpdatePlayField(int i,int j)
        {
            board.UpdateBoard(i,j,playerPlaying.GetPlayerSymbol());
            Render.DisplayBoard(board);   
        }

        private void CheckIfGameWon(WinCondition winCondition)
        {
            if (!winCondition.HasPlayerWon()) return;
            Console.WriteLine("Player " + playerPlaying.GetPlayerNumber() + " has won the game!");
            ExitGame();
        }

        private void ProcessUserPlay(string userPlay)
        {
            playerPlaying.MakeMove(this,userPlay);
            CheckIfGameWon(new WinCondition(playerPlaying, board));
            
        }


        private void ExitGame()
        {
            gameIsFinished = true;
            Environment.Exit(1);
       
        }
        
    }
}