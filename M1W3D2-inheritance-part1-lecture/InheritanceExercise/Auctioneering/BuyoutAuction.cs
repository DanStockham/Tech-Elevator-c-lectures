using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// A buyout auction sets a buyout price that the bidder can use allowing
    /// the auction to end.
    /// </summary>
    public class BuyoutAuction : Auction
    {
        private int buyoutPrice;

        public BuyoutAuction(int buyoutPrice)
        {
            this.buyoutPrice = buyoutPrice;
        }

        public int BuyoutPrice
        {
            get { return buyoutPrice; }
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            bool isCurrentWinningBid = false;

            // Bid can only be considered if the buyout hasn't
            // been reached yet (prior to the bid)
            if (buyoutPrice > CurrentHighBid.BidAmount)
            {
                // If the provided bid is higher or equal to the buyout amt
                if (offeredBid.BidAmount >= buyoutPrice)
                {
                    // Accept the offered bid as winning
                    // Only set it to the buyout amount
                    Bid buyoutBid = new Bid(offeredBid.Bidder, buyoutPrice);

                    // Place bid so that its added to list of bids
                    base.PlaceBid(buyoutBid);

                    Console.WriteLine("Buyout met by " + offeredBid.Bidder);

                    // End Auction since buyout price was met
                    base.EndAuction();

                    // Consider it CurrentWinningBid
                    isCurrentWinningBid = true;
                }
                else
                {
                    // At least check to see if bid is higher than all other bids placed
                    isCurrentWinningBid = base.PlaceBid(offeredBid);
                }
            }

            return isCurrentWinningBid;
        }
    }
}
