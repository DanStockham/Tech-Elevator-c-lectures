using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceLecture.Auctioneering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture.Auctioneering.Tests
{
    [TestClass()]
    public class AuctionTests
    {
        [TestMethod]
        public void high_bid_starts_at_zero()
        {
            Auction theAuction = new Auction();
            Assert.AreEqual(0, theAuction.CurrentHighBid.BidAmount);
        }

        [TestMethod]
        public void keeps_track_of_high_bid()
        {
            Auction theAuction = new Auction();
            theAuction.PlaceBid(new Bid("Kermit", 100));
            theAuction.PlaceBid(new Bid("Miss Piggy", 150));
            theAuction.PlaceBid(new Bid("Fozzie", 125));

            Assert.AreEqual("Miss Piggy", theAuction.CurrentHighBid.Bidder);
            Assert.AreEqual(150, theAuction.CurrentHighBid.BidAmount);
        }

        [TestMethod]
        public void returns_all_bids_in_order_placed()
        {
            Auction theAuction = new Auction();
            theAuction.PlaceBid(new Bid("Kermit", 100));
            theAuction.PlaceBid(new Bid("Miss Piggy", 150));
            theAuction.PlaceBid(new Bid("Fozzie", 125));

            Bid[] bids = theAuction.AllBids;

            Assert.AreEqual(3, bids.Length);
            Assert.AreEqual("Kermit", bids[0].Bidder);
            Assert.AreEqual(100, bids[0].BidAmount);
            Assert.AreEqual("Miss Piggy", bids[1].Bidder);
            Assert.AreEqual(150, bids[1].BidAmount);
            Assert.AreEqual("Fozzie", bids[2].Bidder);
            Assert.AreEqual(125, bids[2].BidAmount);
        }

        [TestMethod]
        public void first_bid_placed_wins_in_case_of_tie()
        {
            Auction theAuction = new Auction();
            theAuction.PlaceBid(new Bid("Kermit", 100));
            theAuction.PlaceBid(new Bid("Miss Piggy", 100));
            Assert.AreEqual("Kermit", theAuction.CurrentHighBid.Bidder);
            Assert.AreEqual(100, theAuction.CurrentHighBid.BidAmount);

        }
    }
}
