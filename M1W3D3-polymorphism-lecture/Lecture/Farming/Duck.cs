using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    public class Duck
    {
        public string NameOfAnimal
        {
            get
            {
                return "Duck";
            }
        }

        public string MakeSoundOnce()
        {
            return "Quack";
        }

        public string MakeSoundTwice()
        {
            return "Quack Quack";
        }
    }
}
