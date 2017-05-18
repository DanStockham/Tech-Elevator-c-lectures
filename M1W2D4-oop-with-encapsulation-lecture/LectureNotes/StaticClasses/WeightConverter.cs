using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureNotes.StaticClasses
{
    public class WeightConverter
    {
        // member variables
        private int instanceVariable = 0;


        public static double ConvertPoundsToOunces(double pounds)
        {
            //instanceVariable = 10; //<-- not allowed
            //because instance variable and this method is static            
             
            return pounds * 16;
        }

        public static double ConvertOuncesToPounds(double ounces)
        {
            double result = ounces / 16;
            return result;
        }
    }
}
