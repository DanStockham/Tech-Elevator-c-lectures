using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture.Auctioneering
{
    // Auction is the Base Class    
    public class Auction
    {
        //It has a Bid object that represents the currentHighBid
        private Bid currentHighBid = new Bid("", 0);

        //It has a collection that represents All Bids
        private List<Bid> allBids = new List<Bid>();

        //the bool hasEnded indicates that the auction is no longer taking place
        private bool hasEnded;              

        public Bid CurrentHighBid
        {
            get { return currentHighBid; }
        }

        public Bid[] AllBids
        {
            get { return allBids.ToArray(); }
        }

        public bool HasEnded
        {
            get { return hasEnded; }
        }

        /// <summary>
        /// Places a Bid on the Auction
        /// </summary>
        /// <param name="offeredBid"></param>
        /// <returns>True if the new bid is the current winning bid</returns>
        public virtual bool PlaceBid(Bid offeredBid)
        {
            Console.WriteLine("Placing bid by " + offeredBid.Bidder + " for $" + offeredBid.BidAmount);

            // Add the bids to allBids
            allBids.Add(offeredBid);

            // Find out if the new bid is the currentWinningBid
            bool isCurrentWinningBid = false;
            if (offeredBid.BidAmount > currentHighBid.BidAmount)
            {
                currentHighBid = offeredBid;
                isCurrentWinningBid = true;
            }

            Console.WriteLine("Current high bid is " + currentHighBid.Bidder + " for $" + currentHighBid.BidAmount);
            Console.WriteLine();

            return isCurrentWinningBid;
        }


        // A Protected function is only available within a class
        // and to subclasses. It is not public so it cannot be seen outside of the class
        // hierarchy.
        //
        // The End Auction method will indicate that the auction ends so that a winner is announced.
        protected void EndAuction()
        {
            hasEnded = true;
            Console.WriteLine("The winning bid goes to " + currentHighBid.Bidder + " for $" + currentHighBid.BidAmount);
        }
        
    }
}
