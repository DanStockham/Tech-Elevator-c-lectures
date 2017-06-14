using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;

namespace CapstoneTests.ClassTests
{
    [TestClass]
    public class ChangeTest
    {
        [TestMethod]
        public void Change_LessThanOneDollar_MixedOutput()
        {
            Change change = new Change(90);

            Assert.AreEqual(3, change.Quarters);
            Assert.AreEqual(1, change.Dimes);
            Assert.AreEqual(1, change.Nickels);
        }

        [TestMethod]
        public void Change_MoreThanOneDollar_MixedOutput()
        {
            Change change = new Change(190);

            Assert.AreEqual(7, change.Quarters);
            Assert.AreEqual(1, change.Dimes);
            Assert.AreEqual(1, change.Nickels);
        }

        [TestMethod]
        public void Change_LargeAmount_MixedOutput()
        {
            Change change = new Change(5490);

            Assert.AreEqual(219, change.Quarters);
            Assert.AreEqual(1, change.Dimes);
            Assert.AreEqual(1, change.Nickels);
        }

        [TestMethod]
        public void Change_IndividualCoinOutputs_Quarters()
        {
            Change one = new Change(25);
            Change two = new Change(50);
            Change three = new Change(75);
            Change four = new Change(100);

            Assert.AreEqual(1, one.Quarters);
            Assert.AreEqual(2, two.Quarters);
            Assert.AreEqual(3, three.Quarters);
            Assert.AreEqual(4, four.Quarters);
        }

        [TestMethod]
        public void Change_IndividualCoinOutputs_Dimes()
        {
            Change one = new Change(10);
            Change two = new Change(20);

            Assert.AreEqual(1, one.Dimes);
            Assert.AreEqual(2, two.Dimes);
        }

        [TestMethod]
        public void Change_IndividualCoinOutputs_Nickels()
        {
            Change one = new Change(5);

            Assert.AreEqual(1, one.Nickels);
        }

    }
}
