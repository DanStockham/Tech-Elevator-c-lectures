using FlyByNightBank.Web.DAL;
using FlyByNightBank.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyByNightBank.Web.Controllers
{
    public class LoanApplicationController : Controller
    {
        private readonly IApplicationDAL applicationDal;

        /*
        * Our IApplicationDAL is injected through the constructor.        
        */
        public LoanApplicationController(IApplicationDAL applicationDal)
        {
            this.applicationDal = applicationDal;
        }

        // GET: LoanApplication/Index
        public ActionResult Index()
        {
            // setup for test of temp data
            // only set in Index action
            Session["sessionName1"] = "sessionValue";
            ViewBag.viewbagName1 = "viewbagValue";
            ViewData["viewdataName1"] = "viewdataValue";
            TempData["tempdataName1"] = "tempdataValue";

            return View("Index");
        }

        // GET: LoanApplication/Start
        public ActionResult Start()
        {

            // setup for test of temp data
            // view contents
            //string session_controller = Session["sessionName1"] as string;
            //string viewbag_controller = ViewBag.viewbagName1 as string;
            //string viewdata_controller = ViewData["viewdataName1"] as string;
            //string tempdata_controller = TempData["tempdataName1"] as string;

            //string session_view = Session["sessionName2"] as string;
            //string viewbag_view = ViewBag.viewbagName2 as string;
            //string viewdata_view = ViewData["viewdataName2"] as string;
            //string tempdata_view = TempData["tempdataName2"] as string;


            return View("Start");
        }

        // POST: LoanApplication/Start
        [HttpPost]
        public ActionResult Start(LoanApplication application)
        {
            // setup for test of temp data
            // view contents
            //string session_controller = Session["sessionName1"] as string;
            //string viewbag_controller = ViewBag.viewbagName1 as string;
            //string viewdata_controller = ViewData["viewdataName1"] as string;
            //string tempdata_controller = TempData["tempdataName1"] as string;

            //string session_view = Session["sessionName2"] as string;
            //string viewbag_view = ViewBag.viewbagName2 as string;
            //string viewdata_view = ViewData["viewdataName2"] as string;
            //string tempdata_view = TempData["tempdataName2"] as string;

            Session["Loan_Application"] = application;

            return RedirectToAction("PersonalContactInformation");
        }

        // GET: LoanApplication/PersonalContactInformation
        public ActionResult PersonalContactInformation()
        {
            return View("PersonalContactInformation");
        }

        // POST: LoanApplication/PersonalContactInformation
        [HttpPost]
        public ActionResult PersonalContactInformation(LoanApplication application)
        {
            LoanApplication existingApplication = Session["Loan_Application"] as LoanApplication;

            if (existingApplication != null)
            {
                existingApplication.HomeAddress = application.HomeAddress;
                existingApplication.HomeCity = application.HomeCity;
                existingApplication.HomeState = application.HomeState;
                existingApplication.HomePostalCode = application.HomePostalCode;
                existingApplication.HomePhone = application.HomePhone;
            }

            Session["Loan_Application"] = existingApplication;

            return RedirectToAction("WorkContactInformation");
        }

        // GET: LoanApplication/WorkContactInformation
        public ActionResult WorkContactInformation()
        {
            return View("WorkContactInformation");
        }

        // POST: LoanApplication/WorkContactInformation
        [HttpPost]
        public ActionResult WorkContactInformation(LoanApplication application)
        {

            LoanApplication existingApplication = Session["Loan_Application"] as LoanApplication;

            if (existingApplication != null)
            {
                existingApplication.JobTitle = application.JobTitle;
                existingApplication.WorkAddress = application.WorkAddress;
                existingApplication.WorkCity = application.WorkCity;
                existingApplication.WorkState = application.WorkState;
                existingApplication.WorkPostalCode = application.WorkPostalCode;
                existingApplication.WorkPhone = application.WorkPhone;
            }

            Session["Loan_Application"] = existingApplication;

            return RedirectToAction("FinancialInformation");
        }

        // GET: LoanApplication/FinancialInformation
        public ActionResult FinancialInformation()
        {
            return View("FinancialInformation");
        }

        // POST: LoanApplication/FinancialInformation
        [HttpPost]
        public ActionResult FinancialInformation(LoanApplication application)
        {

            LoanApplication existingApplication = Session["Loan_Application"] as LoanApplication;

            if (existingApplication != null)
            {
                existingApplication.NetWorth = application.NetWorth;
                existingApplication.Reference1Name = application.Reference1Name;
                existingApplication.Reference1Phone = application.Reference1Phone;
            }

            Session["Loan_Application"] = existingApplication;


            return RedirectToAction("Review");
        }

        // GET: LoanApplication/Review
        public ActionResult Review()
        {
            LoanApplication loanApplication = Session["Loan_Application"] as LoanApplication;

            return View("Review", loanApplication);
        }

        // POST: LoanApplication/Review
        [HttpPost]
        public ActionResult Submit()

        {
            LoanApplication loanApplication = Session["Loan_Application"] as LoanApplication;
            applicationDal.SubmitApplication(loanApplication);
            Session["Loan_Application"] = loanApplication;
            return RedirectToAction("Submitted");
        }

        // GET: Confirmation
        public ActionResult Submitted()
        {
            LoanApplication loanApplication = Session["Loan_Application"] as LoanApplication;
            if (loanApplication != null)
            {
                return View("Submitted", loanApplication);
            }
            else
            {
                return View("Start");
            }
        }

    }
}