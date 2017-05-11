using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops.SampleCode
{
    /*
    * Loops go naturally with arrays
    */ 
    public static class LoopsWithArrays
    {
        /*
        * One very common task is to iterate through each item in an array
        */
        public static void LoopOverArray()
        {
            // Given an array of strings
            string[] stringArray = { "John", "Evan", "Leroy", "Elliot" };

            // Looping from the beginning (0) to the end of an array (Length - 1)
            for(int i = 0; i < stringArray.Length - 1; i++)
            {
                string singleWord = stringArray[i];
                Console.WriteLine(singleWord);
            }
        }

        /*
        * Another common task is to look for an item inside of an array. As with all things in life, 
        * once we find something there is no additional value in looking.
        *
        * The break keyword will end a for-loop no matter where it is at.
        */
        public static void LookForItemInArray()
        {
            // Given an array of odd and even numbers
            int[] integerArray = { 3, 11, 35, 31, 32, 38, 40 };

            // Look through the array and see if it contains at least one even number        
            // Create a variable that indicates if the thing we're looking for was found
            // we havent looked yet so start it at false
            bool evenNumberFound = false; 

            for(int i = 0; i < integerArray.Length; i++)
            {
                // if the number we're looking at (index i) is even
                if(integerArray[i] % 2 == 0)
                {
                    // set evenNumberFound to TRUE
                    evenNumberFound = true;

                    // don't keep looking
                    break;
                }
            }

            Console.WriteLine("Even number found ? " + evenNumberFound);
        }


        /*
        * Another common task is to add up the numbers inside of an array.        
        */
        public static void AddUpArrayNumbers()
        {
            // Given an array
            int[] integerArray = { 0, 1, 3, 1, 0, 2 };

            // We need a variable to hold the sum
            int sum = 0;

            // Loop from the beginning to the end of the array
            for(int i = 0; i < integerArray.Length; i++)
            {
                // Update the sum with the value at integerArray[i] and current value stored in sum
                sum += integerArray[i];
            }
        }

    }
}
