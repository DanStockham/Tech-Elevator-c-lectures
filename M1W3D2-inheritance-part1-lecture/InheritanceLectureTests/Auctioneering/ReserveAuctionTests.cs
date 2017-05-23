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
    public class ReserveAuctionTests
    {
        [TestMethod]
        public void bid_is_ignored_if_less_than_reserve()
        {
            ReserveAuction theAuction = new ReserveAuction(100);
            theAuction.PlaceBid(new Bid("Cheapskate", 99));
            Assert.AreEqual(0, theAuction.AllBids.Length);
        }

        [TestMethod]
        public void bid_is_accepted_if_bid_is_equal_to_reserve()
        {
            ReserveAuction theAuction = new ReserveAuction(100);
            theAuction.PlaceBid(new Bid("Bidder Bob", 100));
            Assert.AreEqual("Bidder Bob", theAuction.CurrentHighBid.Bidder);
            Assert.AreEqual(100, theAuction.CurrentHighBid.BidAmount);
        }
    }
}