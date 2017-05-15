using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string shortSentence = "Technically, C# and Java are offshoots of C++.";
            string longSentence = "Tech Elevator is a coding school. In this class we use C# code to #learnToCode.";

            //strings can have no value which is the same as null
            string nullString = null;

            //strings can be empty as well
            string emptyString = "";


            Console.WriteLine();
            Console.WriteLine("Short Sentence -->" + shortSentence);           
            Console.WriteLine("Long Sentence -->" + longSentence);          
            Console.WriteLine("Null String -->" + nullString);            
            Console.WriteLine("Empty String -->" + emptyString);

            // Strings are objects
            // Using the dot . operator we can access properties and methods that belong to the object.
            // Strings have only one property (.Length) and many different Methods (.Concat, .Substring, .PadLeft, etc.)


            // How do we get the length of each string?
            Console.WriteLine();
            int length = shortSentence.Length;
            Console.WriteLine("Length of Short Sentence " + length);

            
            Console.WriteLine("Length of Long Sentence " + longSentence.Length);

            // We will get an exception if we access a property or method on a variable whose value is null
            //length = nullString.Length;
            //Console.WriteLine("Length of Null Sentence " + length); 

            length = emptyString.Length;
            Console.WriteLine("Length of empty string " + length);


            // Accessing individual characters in a string
            Console.WriteLine();
            char firstCharacter = shortSentence[0];
            Console.WriteLine("First character is " + firstCharacter);
            
            Console.WriteLine("Second character is " + shortSentence[1]);
            
            Console.WriteLine("Last character is " + shortSentence[shortSentence.Length - 1]);


            // Checking for a substring
            Console.WriteLine();
            bool containsCode = shortSentence.Contains("code");
            Console.WriteLine("Short sentence contains code --> " + containsCode);

            containsCode = longSentence.Contains("code");
            Console.WriteLine($"Long sentence contains code " + containsCode);


            // Checking the beginning of a string
            Console.WriteLine();
            bool beginsWithTech = shortSentence.StartsWith("Tech");
            Console.WriteLine("Short sentence begins with Tech --> " + beginsWithTech);

            beginsWithTech = longSentence.StartsWith("Tech");
            Console.WriteLine("Long sentence begins with Tech --> " + beginsWithTech);

            // Making a string lower-case and upper-case
            string lowerCased = shortSentence.ToLower();
            Console.WriteLine("Lower cased --> " + lowerCased);

            string upperCased = shortSentence.ToUpper();
            Console.WriteLine("Upper cased --> " + upperCased);

            // Locating the position of a string
            Console.WriteLine();
            int positionOfC = shortSentence.IndexOf("C#");
            Console.WriteLine("Short sentence position of C# --> " +  positionOfC);

            positionOfC = longSentence.IndexOf("C#");
            Console.WriteLine("Long sentence position of C# --> " + positionOfC);

            int positionOfJava = shortSentence.IndexOf("Java");
            Console.WriteLine("Short sentence position of Java --> " + positionOfJava);

            positionOfJava = longSentence.IndexOf("Java");
            Console.WriteLine($"Long sentence position of Java --> {positionOfJava}");

            // Substring between 2nd and 5th characters
            Console.WriteLine();
            string substring = shortSentence.Substring(1, 4);
            Console.WriteLine("Short sentence 2nd through 5th characters --> " + substring);

            substring = longSentence.Substring(1, 4);
            Console.WriteLine("Long sentence 2nd through 5th characters --> " + substring);

            // Strings are immutable and cannot be changed
            Console.WriteLine();
            shortSentence.Replace("Java", "C#");
            Console.WriteLine("Short sentence --> " + shortSentence);

            string newSentence = shortSentence.Replace("Java", "C#");
            Console.WriteLine("New sentence -- " + newSentence);

            // Splitting a string up into multiple strings
            Console.WriteLine();
            string[] individualSentences = longSentence.Split('.');
            Console.WriteLine("Number of sentences --> " + individualSentences.Length);

            if (String.IsNullOrEmpty(nullString))
            {
                Console.WriteLine("The string either is null or 0 characters long");
            }


            // Concatenating multiple strings
            Console.WriteLine();
            string bigString1 = shortSentence + longSentence;
            Console.WriteLine(bigString1);

            string bigString2 = String.Concat(shortSentence, longSentence);
            Console.WriteLine(bigString2);


            // Formatting output
            Console.WriteLine();
            Console.WriteLine("apples".PadLeft(20));
            Console.WriteLine("bananas".PadLeft(20));
            Console.WriteLine("okra".PadLeft(20));
            Console.WriteLine();

            // Reference Types vs. Value Types
            int valType1 = 5;
            int valType2 = valType1;

            Console.WriteLine($"ValType1 {valType1} and ValType2 {valType2}");

            valType1 = 10;

            Console.WriteLine($"ValType1 {valType1} and ValType2 {valType2}");

            Console.WriteLine();

            string[] refType1 = { "One", "Two", "Three" };
            string[] refType2 = refType1;

            Console.Write("RefType1 ");
            Console.WriteLine(String.Join(", ", refType1));

            Console.Write("RefType2 ");
            Console.WriteLine(String.Join(", ", refType2));

            refType1[1] = "One";
            refType1[2] = "One";
            Console.WriteLine();

            Console.Write("RefType1 ");
            Console.WriteLine(String.Join(", ", refType1));

            Console.Write("RefType2 ");
            Console.WriteLine(String.Join(", ", refType2));

        }
    }
}
