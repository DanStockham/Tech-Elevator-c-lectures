using FlyByNightBank.Web.Models.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyByNightBank.Web.Controllers
{

    public class CalculatorsController : Controller
    {                                
        // GET: Calculators/CompoundInterest
        public ActionResult CompoundInterest()
        {
            return View("CompoundInterest");
        }

        // GET: Calculators/CompoundInterestResult?Principal={0}&NumberOfYears={1}&InterestRate={2}
        public ActionResult CompoundInterestResult(double principal, int numberOfYears, double interestRate)
        {
            CompoundInterestModel model = new CompoundInterestModel()
            {
                Principal = principal,
                NumberOfYears = numberOfYears,
                InterestRate = interestRate
            };

            return View("CompoundInterestResult", model);
        }




        // GET: Calculators/TimeToPayOff
        public ActionResult TimeToPayOff()
        {
            return View("TimeToPayOff");
        }

        // GET: Calculators/TimeToPayOffResult?apr={0}&balance={1}&monthlyPayment={2}
        public ActionResult TimeToPayOffResult(CreditCardPayoffModel model)
        {
            return View("TimeToPayOffResult", model);
        }

        /*
        * Additional exercises to implement with students
        * if examples are needed.
        * Models already exist.
        */

        // GET: Calculators/MonthlyPayment
        public ActionResult MonthlyPayment()
        {
            throw new NotImplementedException();
        }

        // GET: Calculators/MonthlyPaymentResult
        public ActionResult MonthlyPaymentResult(MonthlyPaymentModel model)
        {
            throw new NotImplementedException();
        }


        

    }
}