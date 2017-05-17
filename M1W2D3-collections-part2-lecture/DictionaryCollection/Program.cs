using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // LECTURE NOTES FOR WORKING WITH DICTIONARY COLLECTIONS
            // Dictionaries<T1, T2> can hold two different generic types
            //  T1 - Is the type that represents the key for the dictionary
            //  T2 - Is the type that corresponds to the value for a given key in a dictionary

            //1.  Declaring and Initializing a Dictionary that stores the number of times words appear in a sentence
            //      Example sentence:
            //          its a fair bet that its fair tomorrow and that my fair haired wife will head to the spring fair
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            //2. Values are added to Dictionaries in two ways
            //  .Add(T1 key, T2 value)
            dictionary.Add("its", 2);
            dictionary.Add("a", 1);
            dictionary.Add("fair", 4);
            dictionary.Add("bet", 1);

            // Values can also be added by using the index approach using square brackets []
            // dictionary[key] = value
            dictionary["that"] = 2;
            dictionary["tomorrow"] = 1;
            dictionary["and"] = 1;
            dictionary["my"] = 1;
            dictionary["haired"] = 1;
            dictionary["wife"] = 1;
            dictionary["will"] = 1;
            dictionary["head"] = 1;
            dictionary["to"] = 1;
            dictionary["the"] = 1;
            dictionary["spring"] = 1;

            // NOTE:
            //  If a value already exists in the dictionary and you use .Add to add it, the program will throw
            //  an exception. If you use [key] approach, it will replace the value with a new value.
            

            //3. Retrieving values from a dictionary requires us to know the key
            // If we use dictionary[key] it will return the value
            int valueOfFair = dictionary["fair"];
            int valueOfThat = dictionary["that"];

            Console.WriteLine("Fair appears " + dictionary["fair"] + " times in the sentence");
            Console.WriteLine("That appears " + dictionary["that"] + " times in the sentence");
            Console.WriteLine();


            //4. Looping through all of the items in a dictionary can only be obtained with a foreach loop
            //      Each entry in the dictionary is a KeyValuePair<T1, T2> (KVP) where T1 matches the dictionary T1 and T2
            //      matches the dictionary T2
            //
            //   NOTE: Often you see the foreach loop just call it kvp for short
            foreach (KeyValuePair<string, int> kvp in dictionary)
            {
                // For each KeyValuePair kvp, we can access its key and corresponding value using
                // .Key and .Value
                Console.WriteLine("Key is " + kvp.Key + " - Value is " + kvp.Value);
            }
            Console.WriteLine();


            //5. Dictionaries also have a way of seeing if they Contain a certain key before you try and access it
            //      The .ContainsKey(T1 key) method returns a bool if the key exists or not in the dictionary
            bool containsFair = dictionary.ContainsKey("fair");
            bool containsDad = dictionary.ContainsKey("dad");

            Console.WriteLine("Fair shows up in the dictionary? " + dictionary.ContainsKey("fair"));
            Console.WriteLine("Dad shows up in the dictionary? " + dictionary.ContainsKey("dad"));
            Console.WriteLine();


            // Side Note, .Contains(T1 key) often comes up when you're given a list of keys and you need to see if
            // they all exist in the dictionary and if not, you might add them or print out the dont exist
            string[] words = new string[] { "mom", "dad", "fair", "spring", "super" };
            foreach (string word in words)
            {
                if(dictionary.ContainsKey(word))
                {
                    Console.WriteLine(word + " shows up in the dictionary as a key");
                }
                else
                {
                    Console.WriteLine(word + " does not show up in the dictionary");
                }
            }
            Console.WriteLine();



            //6. Lets try and replace a value in the dictionary. 
            //      Maybe fair appears another time or two
            dictionary["fair"] = dictionary["fair"] + 1;
            Console.WriteLine("Fair appears " + dictionary["fair"] + " times in the sentence");

            dictionary["fair"] = ++dictionary["fair"];
            Console.WriteLine("Fair appears " + dictionary["fair"] + " times in the sentence");



            //7. We can also declare dictionaries and use the collection initializer approach
            //      instead of always typing add
            //   We use lots of curly braces but it makes it shorter if we know the values
            Dictionary<string, bool> dictionary2 = new Dictionary<string, bool>()
            {
                {"word1", false },
                {"word2", true },
                {"word3", false }
            };


            //8. Entries are removed from the dictionary by key as well
            //   To remove entries we use the .Remove(T1 key) method
            dictionary2.Remove("word1");
            dictionary2.Remove("non-existantword"); //its ok if it doesn't exist, no worries


            //9. Converting a Dictionary to an Array uses the .ToArray() method
            //   Its return type is a KeyValuePair<T1, T2>[] (array of Key Value Pairs)
            KeyValuePair<string, bool>[] kvps = dictionary2.ToArray();

        }
    }
}
