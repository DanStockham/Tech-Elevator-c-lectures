using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture.Calculators
{
    // A Scientific Calculator extends the Calculator class.
    // We say a Scientific Calculator "is-a" Calculator.
    public class ScientificCalculator : Calculator
    {

        public double Mod(int quotient)
        {
            result %= quotient;
            return Result;
        }

        public double Tan()
        {
            result = Math.Tan(result);
            return result;
        }

        public double Sin()
        {
            result = Math.Sin(result);
            return result;
        }

        public double Cos()
        {
            result = Math.Cos(result);
            return result;
        }

        

    }
}
