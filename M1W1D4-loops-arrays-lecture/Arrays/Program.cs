using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Creating an array of integers
            int[] quizScores = new int[4];
            quizScores[0] = 100;
            quizScores[1] = 80;
            quizScores[2] = 85;
            quizScores[3] = 90;

            //2. Creating an array of strings
            string[] names = new string[4] { "Josh", "David", "Craig", "Casey" };

            //3. Create an array of characters that hold "Tech Elevator"        
            char[] letters = { 'T', 'e', 'c', 'h', ' ', 'E', 'l', 'e', 'v', 'a', 't', 'o', 'r' };

            //4. Print out the first item in each array
            Console.WriteLine("First quiz score is " + quizScores[0]);
            Console.WriteLine("First name is " + names[0]);
            Console.WriteLine("First letter is " + letters[0]);

            //5. Print out the 3rd item in each array
            Console.WriteLine("3rd quiz score is " + quizScores[2]);
            Console.WriteLine("3rd name is " + names[2]);
            Console.WriteLine("3rd letter is " + letters[2]);

            //6. Get the length of each array
            int lengthOfQuizArray = quizScores.Length;
            Console.WriteLine("There are " + lengthOfQuizArray + " items in quiz array");

            int lengthOfNamesArray = names.Length;
            Console.WriteLine("There are " + lengthOfNamesArray + " items in names array");

            Console.WriteLine("There are " + letters.Length + " items in names array");




            //7. Get the last index 
            //Console.WriteLine("The last index is " + quizScores.Length - 1); doesn't compile why??
            Console.WriteLine("The last index is " + (quizScores.Length - 1));





            //6. Update the last item in each array
            quizScores[quizScores.Length - 1] = 100;
            names[names.Length - 1] = "Josh";            
        }
    }
}
