using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Games
{
    public abstract class Game
    {
        //Constructor
        public Game(int numberOfPlayers)
        {
            this.playersCount = numberOfPlayers;
        }


        //Properties
        private int currentPlayer = -1;
        protected int CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        protected int playersCount;
        public int PlayersCount
        {
            get { return playersCount; }
        }

        //Abstract Methods
        protected abstract void InitializeGame();
        protected abstract bool TakeTurn(int playerNumber);
        protected abstract bool EndOfGame();
        protected abstract void ProclaimWinner();

        //Implementation Method
        public void PlayGame()
        {
            InitializeGame();

            while (!EndOfGame())
            {
                // The approach for writing a loop to increment one player to the next
                // Suppose 4 players in the game
                // Start with 0
                // (0 + 1) % playersCount => 1
                // (1 + 1) % playersCount => 2
                // (2 + 1) % playersCount => 3
                // (3 + 1) % playersCount => 0
                // and repeat
                currentPlayer = (currentPlayer + 1) % playersCount;

                bool goAgain = false;
                do
                {
                    goAgain = TakeTurn(currentPlayer);
                }
                while (goAgain == true);

            }

            ProclaimWinner();
        }

    }
}
