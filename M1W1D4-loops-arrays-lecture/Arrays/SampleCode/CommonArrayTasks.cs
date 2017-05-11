using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SampleCode
{
    public static class CommonArrayTasks
    {
        /*
        * One common task with programming is to swap two values.
        *
        * When this comes up, it often means that a temporary variable needs
        * to be introduced in order to temporarily hold the value while another
        * is put in the final place.            
        */
        public static void SwapEnds()
        {
            // Given an array {1, 3, 13, 15} we want to end up with {15, 3, 13, 1}
            int[] integerArray = { 1, 3, 13, 15 };

            // Declare a temporary variable that can hold a value in the array
            int tempVariable = integerArray[0];

            // Move the last spot into the first spot
            integerArray[0] = integerArray[integerArray.Length - 1];

            // Move the temporary variable into the last spot
            integerArray[integerArray.Length - 1] = tempVariable;
        }



        /*
        * Another task is finding the middle of an array.
        *
        * The total length of the array is .Length / 2
        */
        public static void FindMiddle()
        {
            // Given an array {"Mike", "John", "Joe", "Jason", "Jack"} find the middle "Joe"
            string[] stringArray = { "Mike", "John", "Joe", "Jason", "Jack" };

            // Each item is a string, need a variable to hold an individual item
            string middle = stringArray[stringArray.Length / 2];
        }
    }
}
