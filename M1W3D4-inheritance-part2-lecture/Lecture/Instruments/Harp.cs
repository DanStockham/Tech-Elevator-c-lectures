using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Instruments
{
    // Sealed classes cannot be inherited
    public sealed class Harp : StringedInstrument
    {
        private int height;
        public int Height
        {
            get { return height; }
        }

        public Harp(int height)
            : base()
        {
            this.name = "Harp";
            this.numberOfStrings = 47;
            this.height = height;
        }

        public override void Play()
        {
            Console.WriteLine("Pluck pluck pluck goes the harp");
        }
    }
}
