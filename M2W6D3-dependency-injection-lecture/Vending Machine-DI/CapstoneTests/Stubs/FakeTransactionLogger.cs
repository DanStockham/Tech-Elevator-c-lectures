using Capstone.TransactionLogging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneTests.Stubs
{
    public class FakeTransactionLogger : ITransactionLogger
    {
        public void RecordTransaction(string itemName, string slotID, double initialBalance, double remainingBalance)
        {
            // What this code does doesn't really matter. 
            // It is used so that our Vending Machine tests can run.
            return;
        }
    }
}
