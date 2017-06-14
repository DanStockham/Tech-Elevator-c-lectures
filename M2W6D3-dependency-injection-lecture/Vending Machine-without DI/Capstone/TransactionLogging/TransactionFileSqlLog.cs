using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.TransactionLogging
{
    public class TransactionFileSqlLog
    {
        private string connectionstring;
        private const string SQL_RecordTransaction = "INSERT INTO transaction_log VALUES (@slotId, @productName, @amountAccepted, @remainingBalance, @timestamp);";

        public TransactionFileSqlLog(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public void RecordTransaction(string itemName, string slotID, double initialBalance, double remainingBalance)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_RecordTransaction, conn);
                    cmd.Parameters.AddWithValue("@slotId", slotID);
                    cmd.Parameters.AddWithValue("@productName", itemName);
                    cmd.Parameters.AddWithValue("@amountAccepted", initialBalance);
                    cmd.Parameters.AddWithValue("@remainingBalance", remainingBalance);
                    cmd.Parameters.AddWithValue("@timestamp", DateTime.UtcNow);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine("An error has occurred recording the transaction: " + ex.Message);
            }
        }
    }
}
