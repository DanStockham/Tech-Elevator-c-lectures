using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Change
    {
        //Private Variables
        private int quarters;
        private int dimes;
        private int nickels;
        private readonly double totalChange;
        
        //Properties
        public int Quarters
        {
            get { return quarters; }
        }

        public int Dimes
        {
            get { return dimes; }
        }

        public int Nickels
        {
            get { return nickels; }
        }

        public double TotalChange
        {
            get { return totalChange; }
        }

        /// <summary>
        /// CONSTRUCTOR: Creates a Change object.
        /// </summary>
        /// <param name="amountInCents">Represents the total amount in cents (e.g. $1.59 is 159)</param>
        public Change(int amountInCents)
        {
            totalChange = amountInCents / 100.00;
               
            int tempAmount = amountInCents;
            while (tempAmount > 0)
            //amountInCents is here converted into actual coin amounts
            {
                if (tempAmount >= 25)
                {
                    quarters++;
                    tempAmount = tempAmount - 25;
                }
                else if (tempAmount >= 10)
                {
                    dimes++;
                    tempAmount = tempAmount - 10;
                }
                else if (tempAmount >= 5)
                {
                    nickels++;
                    tempAmount = tempAmount - 5;
                }
            }
        }

        //added to allow for testing
        public override bool Equals(object obj)
        {
            if (obj is Change)
            {
                Change thatOne = (Change)obj;
                return ((this.quarters == thatOne.quarters) && (this.dimes == thatOne.dimes) && (this.nickels == thatOne.nickels));
            }
            return false;
        }
    }
}
