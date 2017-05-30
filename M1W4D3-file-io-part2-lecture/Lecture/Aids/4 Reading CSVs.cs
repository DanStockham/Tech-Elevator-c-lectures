using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Aids
{
    public static class ReadingCSVFiles
    {
        /*
        * Often programmers need to read in csv files and work with each column of data 
        * individually. It usually involves reading files and doing string manipulation
        * at the same time.
        */
        public static void ReadFile()
        {
            // Directory and file name
            string directory = Environment.CurrentDirectory;
            string filename = "words.csv";

            // Full Path
            string fullPath = Path.Combine(directory, filename);

            // Here we'll read in the file, separate each word with a comma and store
            // the individual word in a collection.
            List<string> allWords = new List<string>();

            try
            {
                //Open a StreamReader with the using statement
                // The StreamReader then is automatically disposed so that
                // resources can be cleaned up
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    // Read the file until the end of the stream is reached
                    // EndOfStream is a "marker" that the stream uses to determine 
                    while (!sr.EndOfStream)
                    {
                        // Read in a single line
                        string line = sr.ReadLine();

                        // Split the line by ,
                        string[] words = line.Split(',');

                        // Add each word to allWords
                        allWords.AddRange(words);

                    } //go to the next line until the end is reached
                }
            }
            catch (IOException e) //catch a specific type of Exception
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }


            // Print out each of the words
            foreach (string word in allWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
