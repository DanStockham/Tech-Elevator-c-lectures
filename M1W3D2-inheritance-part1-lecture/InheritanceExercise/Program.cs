using InheritanceLecture.Auctioneering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            Auction generalAuction = new Auction();

            generalAuction.PlaceBid(new Bid("Josh", 1));
            generalAuction.PlaceBid(new Bid("Fonz", 23));
            generalAuction.PlaceBid(new Bid("Rick Astley", 13));
            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids

            //// The rules of a buyout auction automatically end
            //// when the buyout price is met
            //Console.WriteLine();
            //Console.WriteLine("--------------");
            //Console.WriteLine("Buyout Auction");
            //Console.WriteLine();
            //Console.WriteLine();

            //BuyoutAuction buyoutAuction = new BuyoutAuction(55);

            //buyoutAuction.PlaceBid(new Bid("Rick Astley", 20));
            //buyoutAuction.PlaceBid(new Bid("Michael Scott", 30));
            //buyoutAuction.PlaceBid(new Bid("Dwight Schrute", 20));
            //buyoutAuction.PlaceBid(new Bid("Ryan Howard", 56));



            //Console.WriteLine();
            //Console.WriteLine("--------------");
            //Console.WriteLine("Reserve Auction");
            //Console.WriteLine();
            //Console.WriteLine();

            //ReserveAuction reserveAuction = new ReserveAuction(80);

            //reserveAuction.PlaceBid(new Bid("Ted Mosby", 35));
            //reserveAuction.PlaceBid(new Bid("Marshall Erickson", 55));
            //reserveAuction.PlaceBid(new Bid("Barney Stinson", 80));
            //reserveAuction.PlaceBid(new Bid("Lily Erickson", 60));
            //reserveAuction.PlaceBid(new Bid("Robin Sherbatsky", 85));
            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids
        }
    }
}
