using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SampleCode
{
    public static class CheckingArrayEquality
    {
        public static void ArrayEqualitySample()
        {
            // Lets look in an array and check for some values to see if they are equal
            // This creates an array of length 4 shorthand
            int[] integerArray = { 4, 7, 9, 4 };
            string[] stringArray = { "Buzz", "Neil", "John" };

            // Check for the length
            bool isLength4 = (integerArray.Length == 4); //TRUE
            bool isLength2 = (integerArray.Length == 2); //FALSE
            bool isLength3 = (stringArray.Length == 3); //TRUE
            bool isLength5 = (stringArray.Length == 5); //FALSE


            // Check to see if the first item is equal to a value
            bool isFirstItemA4 = (integerArray[0] == 4); //TRUE
            bool isFirstItemA6 = (integerArray[0] == 6); //FALSE
            bool isFirstItemBuzz = (stringArray[0] == "Buzz"); //TRUE
            bool isFirstItemNeil = (stringArray[0] == "Neil"); //FALSE

            // Check to see if the last item is equal to a value
            bool isLastItemA4 = (integerArray[integerArray.Length - 1] == 4); //TRUE
            bool isLastItemJohn = (stringArray[stringArray.Length - 1] == "John"); //TRUE
        }
    }
}
