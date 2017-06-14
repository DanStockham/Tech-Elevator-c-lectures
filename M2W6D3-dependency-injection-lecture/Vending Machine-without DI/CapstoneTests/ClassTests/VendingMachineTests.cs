using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Classes;
using System.Collections.Generic;

namespace CapstoneTests.ClassTests
{
    [TestClass]
    public class VendingMachineTests
    {
        // It isn't possible to write a Vending Machine Unit Test because our Vending Machine
        // is entirely dependent on a InventoryFileDAL and TransactionFileLogger. If the inventory file 
        // doesn't exist the vending machine won't work.
    }
}
