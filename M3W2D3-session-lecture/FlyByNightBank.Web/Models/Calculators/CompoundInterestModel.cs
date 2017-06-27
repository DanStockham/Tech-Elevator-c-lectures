using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyByNightBank.Web.Models.Calculators
{
    /// <summary>
    /// An annual interest calculator assuming no additional contributions.
    /// </summary>
    public class CompoundInterestModel
    {
        public double Principal { get; set; }
        public int NumberOfYears { get; set; }
        public double InterestRate { get; set; }
        
        // This list is static. It is a list of interest rates used with the CompoundInterestCalculator
        // model.
        public static List<SelectListItem> InterestRates { get; } = new List<SelectListItem>()
        {
            new SelectListItem() {Text = "1.0%", Value = "1.0" },
            new SelectListItem() {Text = "1.5%", Value = "1.5" },
            new SelectListItem() {Text = "2.0%", Value = "2.0" },
            new SelectListItem() {Text = "2.5%", Value = "2.5" },
            new SelectListItem() {Text = "3.0%", Value = "3.0" },
            new SelectListItem() {Text = "3.5%", Value = "3.5" },
        };

        /// <summary>
        /// Calculates the formula for amount saved using Principle, InterestRate, and NumberOfYears
        /// </summary>
        /// <returns></returns>
        public double CalculateAmountSaved()
        {
            return Math.Round(Principal * Math.Pow(1 + (InterestRate / 100), NumberOfYears), 2);
        }
    }
}