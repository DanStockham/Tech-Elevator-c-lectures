using Capstone.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;

namespace CapstoneTests.Stubs
{
    public class FakeInventorySource : IInventorySource
    {
        public Dictionary<string, VendingMachineItem> GetInventory()
        {
            // This class will return a fake inventory source.
            return new Dictionary<string, VendingMachineItem>()
            {
                { "A1", new VendingMachineItem("Test Product 1", 100, 1) },
                { "A2", new VendingMachineItem("Test Product 2", 75, 2) },
                { "A3", new VendingMachineItem("Test Product 3", 125, 0) }
            };
        }
    }
}
