using HistoryGeek.Web.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HistoryGeek.Web.Controllers
{
    // ApiController allows us to separate our
    // controllers that handle view logic from controllers that provide output to clients making 
    // asynchronous HTTP requests.
    public class ApiController : Controller
    {
        // GET: Api
        public ActionResult GetTax(string billingZipCode, double subtotal)
        {
            if (String.IsNullOrEmpty(billingZipCode))
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            double taxRate = TaxCalculator.GetTaxRate(billingZipCode);
            double taxTotal = Math.Round(subtotal * taxRate, 2);         
            return Json(taxTotal, JsonRequestBehavior.AllowGet);
        }
    }
}