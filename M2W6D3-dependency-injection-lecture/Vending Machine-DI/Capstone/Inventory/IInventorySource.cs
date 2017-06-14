using Capstone.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Inventory
{
    public interface IInventorySource
    {
        Dictionary<string, VendingMachineItem> GetInventory();
    }
}
