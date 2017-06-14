using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.TransactionLogging
{
    public class TransactionFileLog
    {
        private string filepath;

        public TransactionFileLog(string filepath)
        {
            this.filepath = filepath;
        }


        public void RecordTransaction(string itemName, string slotID, double initialBalance, double remainingBalance)
        {
            string fullPath = Path.Combine(Environment.CurrentDirectory, filepath);
            bool printHeaderRow = !File.Exists(fullPath);  // if the file doesn't exist, print the header row

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    if (printHeaderRow)
                    {
                        sw.Write($"DateTime".PadRight(25));
                        sw.Write($"Product".PadRight(40));
                        sw.Write($"Slot".PadRight(10));
                        sw.Write($"Amount Accepted".PadRight(15));
                        sw.Write($"Remaining Balance".PadRight(15) + "\n");
                    }
                                        
                    sw.Write(DateTime.UtcNow.ToLocalTime().ToString().PadRight(25));
                    sw.Write(itemName.PadRight(40));
                    sw.Write(slotID.PadRight(10));
                    sw.Write(initialBalance.ToString("C").PadRight(15));
                    sw.Write(remainingBalance.ToString("C").PadRight(15) + "\n");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error has occurred recording the transaction: " + ex.Message);
            }
        }
    }
}
