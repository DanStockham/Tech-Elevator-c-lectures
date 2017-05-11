using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops.SampleCode
{
    public static class ForLoops
    {
        /*
        * For loops are good for running something from beginning to end
        * and doing an operation N number of times.
        *
        * Here's a for loop printing a message 10 times
        */
        public static void Print10Times()
        {
            /* 
            * i becomes an incremeneter variable
            * it will start at 1
            * each iteration it will increase by 1
            * this will run forever as long as i is less than or equal to 10
            */
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Hello " + i);
            }
        }

        /*
        * We can increment the variable i by however much we want.
        *
        * If we start at 2 and increment by 2 everytime it will only land on even numbers
        */
        public static void PrintEvenNumbersOnly()
        {
            /*
            * i starts at 2
            * the loop runs as long as i is less than or equal to 20
            * i always incremenets by 2
            */
            for(int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine("EVEN NUMBERS " + i);
            }

        }
    }
}
