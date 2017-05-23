using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture.Auctioneering
{
    public class Bid 
    {
        // Private variables to store bidder and bidAmount
        private string bidder;
        private int bidAmount;

        /// <summary>
        /// Constructor for Bid object. Each Bid requires a bidder and bidAmount
        /// </summary>
        /// <param name="bidder">Who is bidding</param>
        /// <param name="bidAmount">How much bid is for</param>
        public Bid(string bidder, int bidAmount)
        {
            this.bidder = bidder;
            this.bidAmount = bidAmount;
        }

        public string Bidder
        {
            get { return bidder; }
        }

        public int BidAmount
        {
            get { return bidAmount; }
        }

       
    }
}
