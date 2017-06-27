using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlyByNightBank.Web.Models.Calculators
{
    public class CreditCardPayoffModel
    {
        public double APR { get; set; }
        public double Balance { get; set; }
        public double MonthlyPayment { get; set; }

        public int GetNumberOfMonthsToPayoff()
        {
            double percent = APR / 100.00;
            
            double numerator = Math.Log(1 + ((Balance / MonthlyPayment) * (1 - Math.Pow((1 + (percent / 365)), 30))), Math.E);
            double denominator = Math.Log(1 + (percent / 365), Math.E);
            int numberOfPayoffMonths = (int)Math.Ceiling((-1 / 30.0) * (numerator / denominator));

            return numberOfPayoffMonths;
        }
    }
}