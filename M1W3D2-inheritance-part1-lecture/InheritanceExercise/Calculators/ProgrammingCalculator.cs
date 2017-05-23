using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture.Calculators
{
    // A Programming Calculator extends the Calculator class.
    // We say a Programming Calculator "is-a" Calculator.
    public class ProgrammingCalculator : Calculator
    {
        public string ToBinary()
        {
            return Convert.ToString((int)result, 2);
        }
    }
}
