using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintCalculator.Shapes
{
    public class Rectangle
    {
        public int length;
        public int width;


        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle()
        {
            length = 5;
            width = 5;
        }

        // Defines a new method that returns an integer. The method gets the area 
        // using the instance's length and width.
        public int GetArea()
        {
            return length * width;
        }

        public bool IsLarger(Rectangle anotherOne)
        {
            
            if(this.GetArea() > anotherOne.GetArea())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Overloaded method
        public bool IsLarger(int length, int width)
        {
            if (this.GetArea() > (length * width))
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
