using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Cow : IFarmAnimal
    {
        public string NameOfAnimal
        {
            get
            {
                return "Cow";
            }
        }

        public string MakeSoundOnce()
        {
            return "Moo";
        }

        public string MakeSoundTwice()
        {
            return "Moo Moo";
        }
    }
}
