using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlyByNightBank.Web.Models.Calculators
{
    public class MonthlyPaymentModel
    {
        public double LoanAmount { get; set; }
        public int LoanTermInYears { get; set; }
        public double InterestRate { get; set; }

        public double GetMonthlyPayment()
        {
            int loanTermInMonths = LoanTermInYears * 12;
            double monthlyInterestRate = (InterestRate / 12) / 100.00;
            double payment = LoanAmount * ((monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, loanTermInMonths)) / (Math.Pow(1 + monthlyInterestRate, loanTermInMonths) - 1));

            return Math.Round(payment, 2);
        }
    }
}