using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Capstone.Exceptions;

namespace Capstone.Classes
{
    /// <summary>
    /// The VendingMachine CLI handles the entire user interface.
    /// </summary>
    public class VendingMachineCLI
    {
        private const string Option_DisplayVendingMachine = "1";
        private const string Option_DisplayPurchaseMenu = "2";
        private const string Option_InsertMoney = "1";
        private const string Option_MakeSelection = "2";
        private const string Option_ReturnChange = "3";
        private const string Option_ReturnToPreviousMenu = "r";
        private const string Option_Quit = "q";
        private VendingMachine vm;

        public VendingMachineCLI(VendingMachine vm)
        {
            this.vm = vm;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("(1) Display vending machine items");
                Console.WriteLine("(2) Purchase");
                Console.WriteLine("(Q) Quit");
                Console.Write("Please make a choice: ");

                string choice = Console.ReadLine().ToLower();

                if (choice == Option_DisplayVendingMachine)
                {
                    DisplayInventory();
                    Console.ReadKey();
                }
                else if (choice == Option_DisplayPurchaseMenu)
                {
                    Console.Clear();
                    DisplayPurchaseMenu();
                }
                else if (choice == Option_Quit)
                {
                    return;
                }
                else
                {
                    DisplayInvalidOption();
                    Console.ReadKey();
                }

                Console.Clear();
            }
        }

        private void DisplayPurchaseMenu()
        {
            while (true)
            {
                Console.WriteLine("(1) Insert money");
                Console.WriteLine("(2) Make a selection");
                Console.WriteLine("(3) Finish Transaction");
                Console.WriteLine("(R) Return to Main Menu");
                Console.WriteLine();
                Console.WriteLine($"Current balance: {vm.CurrentBalance.ToString("C")}");
                Console.Write("Please make a choice: ");

                string choice = Console.ReadLine().ToLower();

                if (choice == Option_InsertMoney)
                {
                    Console.Write("How much money do you want to enter? ($1, $2, $5, $20): ");
                    int moneyIn = int.Parse(Console.ReadLine());

                    vm.FeedMoney(moneyIn);
                }
                else if (choice == Option_MakeSelection)
                {
                    Console.Write("Please select a slot id: ");
                    string slot = Console.ReadLine().ToUpper();

                    Console.WriteLine();

                    try
                    {
                        VendingMachineItem purchasedItem = vm.Purchase(slot);                      
                        Console.WriteLine("Here are your " + purchasedItem.ItemName);
                    }
                    catch (VendingMachineException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thank you for using Vendo-Matic!");
                        Console.ReadKey();
                    }                                        
                }
                else if (choice == Option_ReturnChange)
                {
                    DisplayReturnedChange();
                    Console.ReadKey();
                }
                else if (choice == Option_ReturnToPreviousMenu)
                {
                    Console.WriteLine("Returning to previous menu. ");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    DisplayInvalidOption();
                }

                Console.Clear();
            }
        }

        private void DisplayInvalidOption()
        {
            Console.WriteLine("The option you selected is not a valid option.");
            Console.WriteLine();
        }

        private void DisplayReturnedChange()
        {
            Change change = vm.ReturnChange();

            Console.WriteLine($"Your change is: {change.TotalChange.ToString("C")}");
            Console.WriteLine($" {change.Quarters} quarters");
            Console.WriteLine($" {change.Dimes} dimes");
            Console.WriteLine($" {change.Nickels} nickels");
            Console.WriteLine();
        }

        private void DisplayInventory()
        {
            Console.Write("Location".PadRight(10));
            Console.Write("Product Name".PadRight(40));
            Console.Write("Purchase Price".PadRight(18));
            Console.WriteLine("Quantity".PadRight(20));

            string[] existingSlots = vm.InventorySlots;

            foreach (string slotId in existingSlots)
            {
                Console.Write(slotId.PadRight(10));
                Console.Write(vm.GetItemAtSlot(slotId).ItemName.PadRight(40));
                Console.Write(((double)(vm.GetItemAtSlot(slotId).PriceInCents) / 100).ToString("C").PadRight(18));
                Console.WriteLine(vm.GetItemAtSlot(slotId).QuantityRemaining.ToString().PadRight(20));
            }
        }
    }
}