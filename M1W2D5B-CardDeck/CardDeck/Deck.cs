using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck
{
    class Deck
    {
        private List<Card> cardDeck = new List<Card>();

        public Deck()
        {

            while(Size < 52)
            {
                Card testCard = Card.RandomCard();

                bool isFound = false;
                foreach(Card thisCard in cardDeck)
                {
                    if (testCard.Equals(thisCard))
                    {
                        isFound = true;
                    }
                }

                if (isFound == false)
                {
                    cardDeck.Add(testCard);
                }
            }

        }
        
        public int Size
        {
            get
            {
                return cardDeck.Count;
            }
        }

        public List<Card> Extract
        {
            get
            {
                List<Card> result = new List<Card>();
                foreach(Card thisCard in cardDeck)
                {
                    result.Add(thisCard);
                }
                return result;
            }
        }


    }
}
