using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald.Farming
{
    public class Duck : FarmAnimal
    {

        public override string MakeSoundOnce()
        {
            return "Quack";
        }

        public override string MakeSoundTwice()
        {
            return "Quack Quack";
        }
        
    }
}
