
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Chicken : IFarmAnimal
    {
        public string NameOfAnimal
        {
            get
            {
                return "Chicken";
            }
        }

        public string MakeSoundOnce()
        {
            return "Cluck";
        }

        public string MakeSoundTwice()
        {
            return "Cluck Cluck";
        }

        public void LayEgg()
        {
            Console.WriteLine("Bakaw");
        }

    }
}
