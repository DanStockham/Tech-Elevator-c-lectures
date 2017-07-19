using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryGeek.Web.Calculators
{
    /// <summary>
    /// This "hypothetical shipping calculator" gives the best rates (if you live very far that is).
    /// It doesn't use distance to calculate the shipping rate. For the sake of simplicity, it uses a 
    /// multiplier (1.5 for standard, 2.25 for Express, etc.) and the weight of the shipment.
    /// 
    /// Ideally in the real-world something much better and profitable would be used such as a 
    /// postage calculator service (e.g. https://www.easypost.com/)
    /// </summary>
    public class ShippingCalculator
    {                                                
        public static Dictionary<string, double> GetShippingRates(double weightInOunces) 
        {
            return new Dictionary<string, double>
            {
                { "Standard", 1.5 * weightInOunces / 16 },
                { "Express", 2.25 * weightInOunces / 16 },
                { "Two-Day", 5.5 * weightInOunces / 16 },
                { "Overnight", 8.25 * weightInOunces / 16 }
            };
        }
        
        
    }

}