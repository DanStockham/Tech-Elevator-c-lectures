using OldMacDonald.Farming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald
{
    class Program
    {
        static void Main(string[] args)
        {

            //
            // OLD MACDONALD
            //

            //Applying Polymorphism, we're allowed to work in terms of 
            // generic types and not concrete classes. In this case
            // the list holds a collection of IFarmAnimal, meaning
            // any class that implements the IFarmAnimal interface is allowed 
            // to be in the list.

            List<ISingable> singable = new List<ISingable>() { new Chicken(), new Cow(), new Duck(), new Tractor() };

            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

            foreach (ISingable singableItem in singable)
            {
                Console.WriteLine("And on his farm there was a " + singableItem.GetType().Name + " ee ay ee ay oh");
                Console.WriteLine("With a " + singableItem.MakeSoundTwice() + " here and a " + singableItem.MakeSoundTwice() + " there");
                Console.WriteLine("Here a " + singableItem.MakeSoundOnce() + ", there a " + singableItem.MakeSoundOnce() + " everywhere a " + singableItem.MakeSoundTwice());
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine();
            }

            
            // --------- WHAT IF
            // What if we want to make sure that if we are singing about farm animals
            // AND they're asleep that they don't make a sound?
            // .... for that there are ABSTRACT CLASSES
            
        }
    }
}
