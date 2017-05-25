using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Instruments
{
    public abstract class Instrument
    {
        // Protected Property, available throughout any subclass
        protected string name;

        public string Name
        {
            get { return name; }
        }

        // Abstract Method Play()
        // Can only be in an abstract class
        // Requires any class that inherits from it, implement the method
        public abstract void Play();
    }
}
