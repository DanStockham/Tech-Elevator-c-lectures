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

            Chicken chicken = new Chicken();
            Cow cow = new Cow();
            Duck duck = new Duck();

            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");
            
            Console.WriteLine("And on his farm there was a " + chicken.NameOfAnimal + " ee ay ee ay oh");
            Console.WriteLine("With a " + chicken.MakeSoundTwice() + " here and a " + chicken.MakeSoundTwice() + " there");
            Console.WriteLine("Here a " + chicken.MakeSoundOnce() + ", there a " + chicken.MakeSoundOnce() + " everywhere a " + chicken.MakeSoundTwice());
            Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
            Console.WriteLine();

            Console.WriteLine("And on his farm there was a " + cow.NameOfAnimal + " ee ay ee ay oh");
            Console.WriteLine("With a " + cow.MakeSoundTwice() + " here and a " + cow.MakeSoundTwice() + " there");
            Console.WriteLine("Here a " + cow.MakeSoundOnce() + ", there a " + cow.MakeSoundOnce() + " everywhere a " + cow.MakeSoundTwice());
            Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
            Console.WriteLine();

            Console.WriteLine("And on his farm there was a " + duck.NameOfAnimal + " ee ay ee ay oh");
            Console.WriteLine("With a " + duck.MakeSoundTwice() + " here and a " + duck.MakeSoundTwice() + " there");
            Console.WriteLine("Here a " + duck.MakeSoundOnce() + ", there a " + duck.MakeSoundOnce() + " everywhere a " + duck.MakeSoundTwice());
            Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
            Console.WriteLine();

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
