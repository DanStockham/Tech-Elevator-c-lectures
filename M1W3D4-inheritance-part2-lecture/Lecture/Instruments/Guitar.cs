using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Instruments
{
    public class Guitar : StringedInstrument
    {
        
        // calls base constructor if constructor is provided, good practice        
        public Guitar(int numberOfStrings) 
            : base()
        {
            this.name = "Guitar";
            this.numberOfStrings = numberOfStrings;
        }

        // Override the Abstract method Play()
        // defined in the Instrument class
        public override void Play()
        {
            Console.WriteLine("Rocking out with the " + numberOfStrings + " stringed guitar");
        }
    }
}
