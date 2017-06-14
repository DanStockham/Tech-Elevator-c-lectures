using Capstone.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Inventory
{
    public class InventorySqlDAL : IInventorySource
    {
        private string connectionstring;

        public InventorySqlDAL(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public Dictionary<string, VendingMachineItem> GetInventory()
        {
            Dictionary<string, VendingMachineItem> output = new Dictionary<string, VendingMachineItem>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM inventory", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string slotid = Convert.ToString(reader["slot_id"]);
                        string name = Convert.ToString(reader["product_name"]);
                        int cost = Convert.ToInt32(reader["cost_in_cents"]);

                        output[slotid] = new VendingMachineItem(name, cost, 5);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred reading the invnentory table. " + ex.Message);
                throw ex;
            }

            return output;
        }
    }
}
