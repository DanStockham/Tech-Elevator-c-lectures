using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryGeek.Web.Calculators
{
    /// <summary>
    /// This "hypothetical tax calculator" gives the best rates (if you live in the right zip code that is).
    /// It doens't look at a real system to determine the right tax rate. It uses the first two digits 
    /// of your zip code to determine the tax rate %.     
    /// 
    /// A much more realistic solution would rely on a tax rate web service to look at the zip code and determine
    /// what the tax rate for that county is.    
    /// </summary>
    public class TaxCalculator
    {
        public static double GetTaxRate(string billingZipcode)
        {
            string firstTwo = billingZipcode.Substring(0, 2);
            double rate = int.Parse(firstTwo) / 100.0;

            return rate;
        }

    }
}