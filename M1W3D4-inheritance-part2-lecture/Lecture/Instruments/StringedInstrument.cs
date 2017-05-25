using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Instruments
{
    // StringedInstrument inherits the Instrument Class
    // It does not have to implement any abstract classes because
    // it itself is also abstract and cannot be instantiated
    public abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        public int NumberOfStrings
        {
            get { return numberOfStrings; }
        }
    }
}
