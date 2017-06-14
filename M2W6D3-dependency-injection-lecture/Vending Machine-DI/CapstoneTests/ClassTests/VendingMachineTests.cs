using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;
using System.Collections.Generic;
using CapstoneTests.Stubs;
using Capstone.Exceptions;

namespace CapstoneTests.ClassTests
{
    [TestClass]
    public class VendingMachineTests
    {
        /*
        * TEST
        * Ensure that a new vending machine has a 0.00 balance.
        */
        [TestMethod]
        public void NewVendingMachine_CurrentBalanceIsZero()
        {
            //Arrange
            VendingMachine vm = new VendingMachine(new FakeInventorySource(), new FakeTransactionLogger());

            //Assert
            Assert.AreEqual(0.00, vm.CurrentBalance);
        }

        /*
        * TEST
        * Using our fake inventory, make sure that .InventorySlots returns the correct Slot IDs.
        */
        [TestMethod]
        public void StockedVendingMachine_InventorySlots_ReturnsAllAvailableSlots()
        {
            //Arrange
            VendingMachine vm = new VendingMachine(new FakeInventorySource(), new FakeTransactionLogger());

            //Assert
            CollectionAssert.AreEqual(new string[] { "A1", "A2", "A3" }, vm.InventorySlots);
        }

        /*
        * TEST
        * Try to purchase an item using an invalid slot.
        */
        [TestMethod]
        [ExpectedException(typeof(InvalidSlotIDException))]
        public void VendingMachine_InvalidSlotId_ThrowsException()
        {
            //Arrange
            VendingMachine vm = new VendingMachine(new FakeInventorySource(), new FakeTransactionLogger());

            //Act
            vm.Purchase("Z4");
        }

        /*
        * TEST
        * Try to purchase an item without feeding money in first.
        */
        [TestMethod]
        [ExpectedException(typeof(InsufficientFundsException))]
        public void VendingMachine_InsufficientBalance_ThrowsException()
        {
            //Arrange
            VendingMachine vm = new VendingMachine(new FakeInventorySource(), new FakeTransactionLogger());

            //Act
            vm.Purchase("A1");
        }


        /*
        * TEST
        * Try to purchase an item (A3) that is out of stock.
        */
        [TestMethod]
        [ExpectedException(typeof(OutOfStockException))]
        public void VendingMachine_OutOfStockItem_ThrowsException()
        {
            //Arrange
            VendingMachine vm = new VendingMachine(new FakeInventorySource(), new FakeTransactionLogger());

            //Act
            vm.Purchase("A3"); // <-- out of stock item
        }


        /*
        * TEST
        * Feed 5 into the vending machine and ensure that CurrentBalance is updated.
        */
        [TestMethod]
        public void VendingMachine_FeedMoneyTest()
        {
            //Arrange
            VendingMachine vm = new VendingMachine(new FakeInventorySource(), new FakeTransactionLogger());

            //Act
            vm.FeedMoney(5);

            //Assert
            Assert.AreEqual(5.00, vm.CurrentBalance);
        }


        /*
        * TEST
        * Feed Money into the Vending Machine.
        * Purchase a Valid Item
        * Ensure that: Balance has been reduced correctly, Quantity is reduced, and Correct Item is returned.
        */
        [TestMethod]
        public void VendingMachine_ValidPurchaseTest()
        {
            //Arrange
            VendingMachine vm = new VendingMachine(new FakeInventorySource(), new FakeTransactionLogger());

            //Act
            vm.FeedMoney(5);
            VendingMachineItem purchasedItem = vm.Purchase("A1");

            //Assert
            Assert.AreEqual(4.00, vm.CurrentBalance);
            Assert.AreEqual(0, purchasedItem.QuantityRemaining);
            Assert.AreEqual("Test Product 1", purchasedItem.ItemName);
        }


        /*
        * TEST
        * Validate GetItemAtSlot for valid slot id returns a copy of the item.
        * Calling it again should get another new copy for the same item.
        */
        [TestMethod]
        public void VendingMachine_GetItemAtValidSlot()
        {
            //Arrange
            VendingMachine vm = new VendingMachine(new FakeInventorySource(), new FakeTransactionLogger());

            //Act
            VendingMachineItem itemAtSlot = vm.GetItemAtSlot("A1");
            VendingMachineItem sameItem = vm.GetItemAtSlot("A1");

            //Assert
            Assert.IsNotNull(itemAtSlot);
            Assert.IsNotNull(sameItem);
            Assert.AreNotEqual(itemAtSlot, sameItem);
            Assert.AreEqual(itemAtSlot.ItemName, sameItem.ItemName);
        }


        /*
        * TEST
        * Try to get an item that does not exist in the valid slots.
        */
        [TestMethod]
        [ExpectedException(typeof(InvalidSlotIDException))]
        public void VendingMachine_GetItemAtInvalidSlot_ThrowsException()
        {
            //Arrange
            VendingMachine vm = new VendingMachine(new FakeInventorySource(), new FakeTransactionLogger());

            //Act
            VendingMachineItem itemAtSlot = vm.GetItemAtSlot("ZZ");
        }


        /*
        * TEST
        * Put Money into the Vending Machine. Get back same amount in Change object
        * The correctness of the change is in the ChangeTests
        */
        [TestMethod]
        public void VendingMachine_ReturnAllChange()
        {
            //Arrange
            VendingMachine vm = new VendingMachine(new FakeInventorySource(), new FakeTransactionLogger());

            //Act
            vm.FeedMoney(7);
            Change returnedChange = vm.ReturnChange();


            //Assert
            Assert.IsNotNull(returnedChange);
            Assert.AreEqual(7.00, returnedChange.TotalChange);
        }
    }
}
