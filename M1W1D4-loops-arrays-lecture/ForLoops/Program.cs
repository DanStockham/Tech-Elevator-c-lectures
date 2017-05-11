using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Printing out "Hello World" 10 times
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World");
            }


            //2. Printing out the numbers from 1 to 50
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine(i);
            }


            //3. Printing the odd numbers from 1 to 50
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Attempt 1
            for (int i = 0; i < 51; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            // Attempt 2
            for (int i = 0; i < 51; i += 2)
            {
                Console.WriteLine(i);
            }


            //4. How would we find the sum of even numbers 1 through 50 using a for loop?
            int sum = 0;

            for (int i = 0; i <= 50; i++)
            {
                sum = sum + i;
            }

            //5. How could we convert the celsius temperatures of an array to Farenheit?
            int[] celsiusTemps = new int[5] { 13, 20, 35, 22, 50 };
            for (int i = 0; i < celsiusTemps.Length; i++)
            {
                int farenheitTemp = (int)((celsiusTemps[i] * 1.8) + 32);
                Console.WriteLine($"{celsiusTemps[i]} degrees C is {farenheitTemp} degrees F.");
            }

            Console.WriteLine("The sum from 1 to 50 is " + sum);
        }
    }
}
