using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Games
{
    public class BoardGame : Game
    {
        // This array will track the position of each player
        // in the game. First player that reaches WinningSpaceNumber wins
        private int[] playerPositions;
        Random randomDie = new Random();


        private const int WinningSpaceNumber = 20;


        // Our Game class needs to know how many players
        // but the BoardGame class is what gets instantiated
        // It needs a constructor that passes up the number of players
        // to the base Game constructor
        public BoardGame(int numberOfPlayers) :
            base(numberOfPlayers)
        {
            playerPositions = new int[numberOfPlayers];
        }


        protected override bool EndOfGame()
        {
            for(int i = 0; i < playerPositions.Length; i++)
            {
                if (playerPositions[i] >= WinningSpaceNumber)
                {
                    return true;
                }
            }

            return false;
        }

        protected override void InitializeGame()
        {
            //Everyone in the game starts at position 1
            for (int i = 0; i < playerPositions.Length; i++)
            {
                Console.WriteLine($"Putting player {i + 1} at position 1");
                playerPositions[i] = 1;
            }
        }

        protected override void ProclaimWinner()
        {
            for(int i = 0; i < playerPositions.Length; i++)
            {
                if (playerPositions[i] >= WinningSpaceNumber)
                {
                    Console.WriteLine($"PLAYER {i + 1} is the winner!");
                }
            }
        }

        protected override bool TakeTurn(int playerNumber)
        {
            // Rules are: player throws two die from 1-12 and moves ahead that many spaces.
            // If they get doubles then they get to go again (return true).
            // If they don't get doubles then their turn is over (return false);

            Console.WriteLine();
            Console.WriteLine($"PLAYER {playerNumber + 1} TURN.");


            int firstRoll = randomDie.Next(1,7);
            int secondRoll = randomDie.Next(1,7);

            Console.WriteLine($"PLAYER {playerNumber + 1} rolled a {firstRoll} and a {secondRoll}");
                                    
            playerPositions[playerNumber] += (firstRoll + secondRoll); //move forward that many spaces

            Console.WriteLine($"PLAYER {playerNumber + 1} moved to position {playerPositions[playerNumber]}");
            Console.WriteLine();

            return (firstRoll == secondRoll); //doubles returns true
        }
    }
}
