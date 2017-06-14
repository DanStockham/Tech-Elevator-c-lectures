using Capstone.Exceptions;
using Capstone.Inventory;
using Capstone.TransactionLogging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        //Private variables
        private IInventorySource inventorySource;
        private ITransactionLogger transactionLogger;        
        private Dictionary<string, VendingMachineItem> inventory;
        private int currentBalance;
        

        /// <summary>
        /// Constructor for new vending machine. Inventory is automatically stocked when creating the machine.
        /// </summary>
        public VendingMachine(IInventorySource inventorySource, ITransactionLogger transactionLogger)
        {
            this.inventorySource = inventorySource;
            this.transactionLogger = transactionLogger;

            inventory = inventorySource.GetInventory();
        }

        /// <summary>
        /// Reflects the Current Balance (in dollars and cents) for the Vending Machine
        /// </summary>
        public double CurrentBalance
        {
            get { return (currentBalance / 100.00); }
        }

        /// <summary>
        /// Returns all of the available slots in the inventory.
        /// </summary>
        public string[] InventorySlots
        {
            get { return inventory.Keys.ToArray(); }
        }


        /// <summary>
        /// Purchases the item at Slot Id. Ensures the slot exists, quantity is available, and a sufficient balance is provided.
        /// </summary>
        /// <param name="slotID"></param>
        /// <returns></returns>
        public VendingMachineItem Purchase(string slotID)
        {
            if (!inventory.ContainsKey(slotID))
            {
                throw new InvalidSlotIDException($"{slotID} is not a valid slot.");
            }

            if (inventory[slotID].QuantityRemaining == 0)
            {
                throw new OutOfStockException("The quantity in stock is 0.");
            }

            if (currentBalance < inventory[slotID].PriceInCents)
            {
                throw new InsufficientFundsException($"Balance is insufficient to purchase this item.");
            }

            double initialBalance = CurrentBalance;

            inventory[slotID].QuantityRemaining--;            
            currentBalance -= inventory[slotID].PriceInCents;
            
            transactionLogger.RecordTransaction(inventory[slotID].ItemName, slotID, initialBalance, CurrentBalance);

            return GetItemAtSlot(slotID);
        }



        /// <summary>
        /// Returns a vending machine item at a given slot.
        /// </summary>
        /// <param name="slotId"></param>
        /// <returns></returns>
        /// <remarks>Does not return a reference to the item in inventory.</remarks>
        public VendingMachineItem GetItemAtSlot(string slotId)
        {
            if (!inventory.ContainsKey(slotId))
            {
                throw new InvalidSlotIDException($"{slotId} is not a valid slot");
            }

            // Create a copy of the item and return it
            return new VendingMachineItem(inventory[slotId].ItemName, inventory[slotId].PriceInCents, inventory[slotId].QuantityRemaining);
        }


        /// <summary>
        /// Feeds money into the vending machine.
        /// </summary>        
        public void FeedMoney(int dollars)
        {
            currentBalance += dollars * 100;
        }

        /// <summary>
        /// Called by the user interface to return the Change.
        /// </summary>        
        public Change ReturnChange()
        {
            Change change = new Change(currentBalance);
            currentBalance = 0;
            return change;
        }        
    }
}
