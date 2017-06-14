using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Exceptions
{
    public class VendingMachineException : Exception
    {
        public VendingMachineException()
        {
        }

        public VendingMachineException(string message)
            : base(message)
        {
        }

        public VendingMachineException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
