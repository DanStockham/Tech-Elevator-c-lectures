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
    public class BuyoutAuctionTests
    {
        [TestMethod]
        public void bids_made_after_buyout_price_met_are_ignored()
        {
            BuyoutAuction theAuction = new BuyoutAuction(100);
            theAuction.PlaceBid(new Bid("Buyout Bob", 100));
            theAuction.PlaceBid(new Bid("Too Late Tom", 101));
            Assert.AreEqual(1, theAuction.AllBids.Length);
            Assert.AreEqual("Buyout Bob", theAuction.CurrentHighBid.Bidder);
            Assert.AreEqual(100, theAuction.CurrentHighBid.BidAmount);
        }

        [TestMethod]
        public void bids_greater_than_buyout_price_are_reduced_to_buyout_price()
        {
            BuyoutAuction theAuction = new BuyoutAuction(100);
            theAuction.PlaceBid(new Bid("Big Spender", 200));
            Assert.AreEqual("Big Spender", theAuction.CurrentHighBid.Bidder);
            Assert.AreEqual(100, theAuction.CurrentHighBid.BidAmount);
        }
    }
}