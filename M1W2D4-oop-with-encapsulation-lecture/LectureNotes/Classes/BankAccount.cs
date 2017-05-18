using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureNotes.Classes
{
    /// <summary>
    /// The bank account class is used to demonstrate encapsulation
    /// A Bank account never lets you "change the balance" unless you
    /// withdraw or deposit money    
    /// </summary>           
    public class BankAccount
    {
        private string accountNumber;
        private string accountHolder;
        private decimal balance;


        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        ///////////////
        // DATA MEMBERS
        ///////////////
        /// <summary>
        /// An account number is defined when the class is created
        /// </summary>
        public string AccountNumber
        {
            get { return this.accountNumber; }
        }

        /// <summary>
        /// The bank account holder can change during the lifetime of the
        /// account
        /// </summary>
        public string AccountHolder
        {
            get { return this.accountHolder; }
            set { this.accountHolder = value; }
        }

        /// <summary>
        /// Represents the current bank account balance
        /// </summary>
        public decimal Balance
        {
            get { return this.balance; }
        }

        /// <summary>
        /// Withdraws money from the account. The balance is updated after
        /// withdrawing money.
        /// </summary>        
        /// <param name="amount"></param>
        public void Withdraw(decimal amount)
        {
            //Encapsulation by Data Hiding
            this.balance = this.balance - amount;
        }

        
        /// <summary>
        /// Deposits money into the account. The balance is updated
        /// after adding money.
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(decimal amount)
        {
            //Encapsulation by Data Hiding
            this.balance = this.balance + amount;            
        }
        
    }
}
