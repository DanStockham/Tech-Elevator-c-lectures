using Lecture.Farming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
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

            List<IFarmAnimal> theseAmimals = new List<IFarmAnimal>();

            theseAmimals.Add(new Chicken());
            theseAmimals.Add(new  Cow());
            theseAmimals.Add(new  Duck());

            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");
            
         foreach (IFarmAnimal thisAnimal in theseAmimals)
            {
                Console.WriteLine("And on his farm there was a " + thisAnimal.NameOfAnimal + " ee ay ee ay oh");
                Console.WriteLine("With a " + thisAnimal.MakeSoundTwice() + " here and a " + thisAnimal.MakeSoundTwice() + " there");
                Console.WriteLine("Here a " + thisAnimal.MakeSoundOnce() + ", there a " + thisAnimal.MakeSoundOnce() + " everywhere a " + thisAnimal.MakeSoundTwice());
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine();
            }



            // ----- THIS IS GETTING REPETITIVE! 
            // We can do better
            // How can we use what we've learned about inheritance
            // to help us remove code duplication
            // 
            // What if we create some sort of base class that all our animals have in common?
            


            // ------ NOW
            // What if we wanted to sing about other things on the farm?
            // Can it be done? 

        }
    }
}
