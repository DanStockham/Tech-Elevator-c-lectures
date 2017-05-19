using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Add a using statement


namespace ShapeExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("[1] Add a wall");
                Console.WriteLine("[2] Calculate paint required (and Exit)");
                Console.Write("Please choose >>> ");
                string userChoice = Console.ReadLine();

                Console.WriteLine();

                if(userChoice == "1")
                {
                    Console.Write("Enter wall height >>> ");
                    int height = int.Parse(Console.ReadLine());
                    Console.Write("Enter wall width >>> ");
                    int width = int.Parse(Console.ReadLine());
                    int area = height * width;

                    Console.WriteLine("Added " + height + "x" + width + " wall - " + area + " square feet");
                }
                else if (userChoice == "2")
                {
                    // Here we need to sum up the areas of all walls that have been entered
                    Console.WriteLine("Wall 1: 10x15 - 150 square feet"); // PROTOTYPE ONLY!!!
                    Console.WriteLine("Wall 2: 10x15 - 150 square feet"); // PROTOTYPE ONLY!!!
                    Console.WriteLine("Wall 3: 10x15 - 150 square feet"); // PROTOTYPE ONLY!!!
                    Console.WriteLine("Wall 4: 10x15 - 150 square feet"); // PROTOTYPE ONLY!!!

                    int totalArea = 600; // PROTOTYPE ONLY!!!
                    Console.WriteLine("===============================");
                    Console.WriteLine("Total Area: " + totalArea + " square feet");

                    // 1 gallon of paint covers 400 square feet
                    double gallonsRequired = (double)totalArea / 400;
                    Console.WriteLine("Paint Required: " + gallonsRequired + " gallons");

                    return;
                }
            }

        }
    }
}
