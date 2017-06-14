using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachineItem
    {
        // Constants
        private const int DefaultQuantity = 5;

        // Private Variables
        private string itemName;
        private int priceInCents;
        private int quantityRemaining;
        
        // Properties
        public string ItemName
        {
            get { return itemName; }
        }

        public int PriceInCents
        {
            get { return priceInCents; }
        }

        public int QuantityRemaining
        {
            get { return quantityRemaining; }
            set { quantityRemaining = value; }
        }
        
        //Constructors
        public VendingMachineItem(string itemName, int priceInCents)
            : this(itemName, priceInCents, DefaultQuantity)
        {
        }


        public VendingMachineItem(string itemName, int priceInCents, int quantityRemaining)
        {
            this.itemName = itemName;
            this.priceInCents = priceInCents;
            this.quantityRemaining = quantityRemaining;
        }
    }
}
