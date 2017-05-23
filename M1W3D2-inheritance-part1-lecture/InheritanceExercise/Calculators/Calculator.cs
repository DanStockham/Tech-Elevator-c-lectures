using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture.Calculators
{
    public class Calculator
    {
        protected double result;
        public double Result
        {
            get { return result; }
        }

        public void Reset()
        {
            result = 0;
        }

        public void EnterNumber(double number)
        {
            result = number;
        }

        public double Add(double addend)
        {
            result += addend;
            return result;
        }

        public double Subtract(double subtrahend)
        {
            result -= subtrahend;
            return result;
        }

        public double Multiply(double multiplier)
        {
            result *= multiplier;
            return result;
        }

        public double Divide(double quotient)
        {
            if (quotient == 0)
            {
                return double.NaN;
            }

            result /= quotient;
            return result;
        }
    }
}
