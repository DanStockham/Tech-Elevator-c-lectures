using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// A reserve auction has a minimum reserve price that must be met before
    /// the bid is considered worthy.
    /// </summary>
    public class ReserveAuction : Auction
    {
        private int reservePrice;

        public ReserveAuction(int reservePrice)
        {
            this.reservePrice = reservePrice;
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            bool isCurrentWinningBid = false;

            // Only consider if it meets the reserve price
            if(offeredBid.BidAmount >= reservePrice)
            {                
                // Set it to current winning bid if the base
                // class behavior determines its higher than all other bids
                isCurrentWinningBid = base.PlaceBid(offeredBid);

                Console.WriteLine("Reserve has been met");
                Console.WriteLine();
            }

            return isCurrentWinningBid;
        }
    }
}
