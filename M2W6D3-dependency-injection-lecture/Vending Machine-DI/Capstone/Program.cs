using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;
using Capstone.Inventory;
using Capstone.TransactionLogging;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            const string localConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=VendingMachine;Integrated Security=True";

            // Instantiate the dependencies

            IInventorySource inventorySource;
            ITransactionLogger transactionLogger;

            string mode = Properties.Settings.Default.DataSource;

            if (mode == "file")
            {
                inventorySource = new InventoryFileDAL("vendingmachine.csv");
                transactionLogger = new TransactionFileLog("transactions.txt");
            }
            else
            {
                inventorySource = new InventorySqlDAL(localConnectionString);
                transactionLogger = new TransactionFileSqlLog(localConnectionString);

            }

            VendingMachine vm;

            try
            {
                // Inject the dependency into the class using the constructor
                vm = new VendingMachine(inventorySource, transactionLogger);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("An error occurred starting the vending machine. The program is going to exit.");
                return;
            }

            // Start the CLI and run the menu
            VendingMachineCLI cli = new VendingMachineCLI(vm);
            cli.Run();
        }
    }
}
