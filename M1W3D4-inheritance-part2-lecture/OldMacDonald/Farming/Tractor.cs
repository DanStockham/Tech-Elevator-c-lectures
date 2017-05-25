using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald.Farming
{
    public class Tractor : ISingable
    {
        public string MakeSoundOnce()
        {
            return "Vroom";
        }

        public string MakeSoundTwice()
        {
            return "Vroom Vroom";
        }
    }
}
