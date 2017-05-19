using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck

{
    class Card
    {
        private char suit;

        public Card()
        {

        }

        public Card(char suit, int rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public char Suit
        {
            get
            {
                return suit;
            }
            set
            {
                suit = value;
            }
        }

        public int Rank
        {
            get;
            set;
        }
      
        public bool Equals(Card inputCard)
        {
            if (Suit == inputCard.Suit && Rank == inputCard.Rank) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SameSuit(Card inputCard)
        {
            if (Suit == inputCard.Suit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Card RandomCard()
        {
            Random myRandom = new Random();
            
            char[] suits = new char[4]{ 'h', 'c', 's', 'd'};
            int i = myRandom.Next(0, 4);
            char randSuit = suits[i];

            int j = myRandom.Next(1, 14);
            int randRank = j;

            Card result = new Card(randSuit, randRank);
            return result;
        }
    }
}
