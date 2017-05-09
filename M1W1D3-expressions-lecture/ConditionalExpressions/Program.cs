using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("*** IF STATEMENTS ***");
            Console.WriteLine("*******************************");
            Console.WriteLine();

            int numberOfPeople = 25;
            int slicesOfCake = 22;

            if (numberOfPeople <= slicesOfCake)
            {
                Console.WriteLine("Yummy! Cake!");
            }
            else
            {
                Console.WriteLine("Burn the building down...");
            }

            bool condition1 = true;
            bool condition2 = true;
            if (condition1)
            {
                Console.WriteLine("Condition 1 is true!");
            }
            else if (condition2)
            {
                Console.WriteLine("Condition 2 is true!");
            }
            else
            {
                Console.WriteLine("No conditions are true!");
            }


            bool staplerIsSwingline = false;
            if (staplerIsSwingline)
                Console.WriteLine("Better be red...");

            Console.WriteLine("And we continue...");

            if (numberOfPeople <= slicesOfCake)
            {
                Console.WriteLine("Yummy! Cake!");
            }
            else
            {
                Console.WriteLine("Walk away mumbling...");
                Console.WriteLine("Burn the building down...");
            }



            Console.WriteLine("*******************************");
            Console.WriteLine("*** VARIABLE SCOPE ***");
            Console.WriteLine("*******************************");
            Console.WriteLine();

            int firstVariable = 2;
            if (firstVariable > 0)
            {
                int secondVariable = firstVariable;
            }
            //int thirdVariable = secondVariable * 2; // this will cause a compile error because secondVariable is not "in scope"
            //int firstVariable = 3;  // this is a compiler error because we already have a variable named firstVariable in this scope


            Console.WriteLine("*******************************");
            Console.WriteLine("********** METHODS ************");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            bool burnItDown = ShouldBurnDownTheBuilding(14, 20);

            
        }

        static bool ShouldBurnDownTheBuilding(int numberOfEmployees, int piecesOfCake)
        {
            if (numberOfEmployees > piecesOfCake)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

    }
}
