using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Instruments
{
    public class Lute : StringedInstrument
    {
        public Lute()
            : base()
        {
            this.name = "Lute";
            this.numberOfStrings = 15;            
        }
        
        // The Lute must provide an implementation for Play, the abstract method defined
        // in Instrument class
        public override void Play()
        {
            Console.WriteLine("The bard plays the lute");
        }
    }
}
