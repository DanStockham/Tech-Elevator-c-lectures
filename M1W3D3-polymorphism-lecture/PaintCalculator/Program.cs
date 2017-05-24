
using PaintCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Rectangle> walls = new List<Rectangle>();

            while (true)
            {
                Console.WriteLine("[1] Add a wall");
                Console.WriteLine("[2] Calculate paint required (and Exit)");
                Console.Write("Please choose >>> ");
                string userChoice = Console.ReadLine();

                Console.WriteLine();

                if (userChoice == "1")
                {
                    Console.Write("Enter wall height >>> ");
                    int height = int.Parse(Console.ReadLine());
                    Console.Write("Enter wall width >>> ");
                    int width = int.Parse(Console.ReadLine());

                    Rectangle wall = new Rectangle(height, width);

                    Console.WriteLine("Added " + wall.length + "x" + wall.width + " wall - " + wall.GetArea() + " square feet");
                    walls.Add(wall);
                }
                else if (userChoice == "2")
                {

                    int totalArea = 0;
                    for(int i = 0; i < walls.Count; i++)
                    {
                        Console.WriteLine($"Wall {i + 1}: {walls[i].length}x{walls[i].width} - {walls[i].GetArea()} square ft");
                        totalArea = totalArea + walls[i].GetArea();
                    }

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
