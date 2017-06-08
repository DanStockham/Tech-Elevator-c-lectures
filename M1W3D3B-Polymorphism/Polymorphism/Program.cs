using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] theseShapes = new Shape[3];

            Circle circle1 = new Circle();
            circle1.Area = 2.3;
            circle1.Perimiter = 45.3;

            Square square1 = new Square();
            square1.Area = 7.0;
            square1.Perimiter = 55;
   
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Area = 123.0;
            rectangle1.Perimiter = 978.0;

            theseShapes[0] = circle1;
            theseShapes[1] = square1;
            theseShapes[2] = rectangle1;

            for (int i = 0; i < theseShapes.Length; i++)
            {
                Console.WriteLine(theseShapes[i].ToString());
            }

            Console.ReadLine();








        }
    }
}
