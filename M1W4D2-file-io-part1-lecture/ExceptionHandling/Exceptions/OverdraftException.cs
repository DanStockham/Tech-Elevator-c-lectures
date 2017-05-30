using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Exceptions
{
    public class OverdraftException : Exception
    {
        private double overdraftAmount = 0.0;
        public double OverdraftAmount
        {
            get { return overdraftAmount; }            
        }

        public OverdraftException(string message, double overdraftAmount)
            : base(message)
        {
            this.overdraftAmount = overdraftAmount;
        }
    }
}
