using Capstone.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Inventory
{
    public class InventoryFileDAL
    {
        private string filepath;

        public InventoryFileDAL(string filepath)
        {
            this.filepath = filepath;
        }

        public Dictionary<string, VendingMachineItem> GetInventory()
        {            
            List<string[]> fullList = new List<string[]>();
            Dictionary<string, VendingMachineItem> placeholder = new Dictionary<string, VendingMachineItem>();

            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        string[] list = line.Split('|');
                        fullList.Add(list);
                    }

                    foreach (string[] array in fullList)
                    {
                        placeholder[array[0]] = new VendingMachineItem(array[1], int.Parse(array[2]));
                    }
                }
            }
            catch (IOException)
            {

                throw new IOException();
            }

            return placeholder;
        }
    }
}
