using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();

            int deckSize = newDeck.Size;

            Card card1 = new Card();
            Card card2 = new Card();
            card1.Suit = 'h';
            card1.Rank = 2;

            card2.Suit = 'h';
            card2.Rank = 2;

            if (card1.Equals(card2))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
