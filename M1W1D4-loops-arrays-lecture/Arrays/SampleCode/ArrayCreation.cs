using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.SampleCode
{
    public static class ArrayCreation
    {
        static void CreateArraySample()
        {
            // Arrays are declared using any of the following formats
            // datatype[] variable-name = new datatype[int length];
            // datatype[] variable-name = new datatype[] {val1, val2, val3};
            // datatype[] variable-name = {val1, val2, val3}; <-- shorthand

            // Declaring an array (of length 4) that holds integers
            // And setting the values
            int[] integerArray = new int[4];            
            integerArray[0] = 1;
            integerArray[1] = 3;
            integerArray[2] = 5;
            integerArray[3] = 2;
            //integerArray[4] = 10; //not allowed because the array is length 4         

            // Declaring an array that holds strings
            string[] stringArray = new string[3];
            stringArray[0] = "Mike";
            stringArray[1] = "Jack";
            stringArray[2] = "Jane";
            //stringArray[3] = "Mark"; //not allowed because array is length 3

            // Declaring an array of chars
            char[] charArray = new char[3];
            charArray[0] = 'c';
            charArray[1] = 'h';
            charArray[2] = 'a';
            charArray[3] = 'r'; //not allowed because array is length 3

            /////////////////
            // We get the array values using
            // the name of the array and the position we want to get            
            int firstValue = integerArray[0];
            string secondValue = stringArray[1];

            
            /*
            * Arrays have a property called Length that returns the size of the array.
            * It is best when we "dont know the size ahead of time" and write our program to work
            *  with any size array.
            *
            * The .Length property will return you the size of the array.
            * Therefore .Length - 1 is equal to the last position in the array.
            */
            char lastValue = charArray[charArray.Length - 1];
        }
    }
}
