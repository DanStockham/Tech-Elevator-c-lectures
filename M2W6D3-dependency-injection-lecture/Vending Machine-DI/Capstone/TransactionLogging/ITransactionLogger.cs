using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.TransactionLogging
{
    public interface ITransactionLogger
    {
        void RecordTransaction(string itemName, string slotID, double initialBalance, double remainingBalance);
    }
}
