using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Shape
    {
        protected double area;
        protected double perimiter;

        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }

        public double Perimiter
        {
            get
            {
                return perimiter;
            }
            set
            {
                perimiter = value;
            }
        }

        public override string ToString()
        {
            return ($"Area of Shape is {area} and perimiter is {perimiter }");

        }
    }

    class Square : Shape
    {
        public override string ToString()
        {
            return ($"Area of Square is {area} and perimiter is {perimiter }");
        }

    }

    class Rectangle : Shape
    {

        public override string ToString()
        {
            return ($"Area of Rectangle is {area} and perimiter is {perimiter}");
        }
    }

    class Circle : Shape
    {
        public override string ToString()
        {
            return ($"Area of Circle is {area} and perimiter is {perimiter }");
        }
    }
}
