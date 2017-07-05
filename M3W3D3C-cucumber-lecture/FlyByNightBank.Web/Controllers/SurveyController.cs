using FlyByNightBank.Web.DAL;
using FlyByNightBank.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyByNightBank.Web.Controllers
{
    public class SurveyController : Controller
    {
        private ISurveyDAL surveyDal;


        public SurveyController(ISurveyDAL surveyDal)
        {
            this.surveyDal = surveyDal;
        }

        /*
        * Controller Action used when a customer REQUESTS to take a survey.        
        */
        // GET: Survey/Index
        // GET: Survey/
        public ActionResult Index()
        {
            return View("Index");
        }

        /*
        * Controller Action used when a customer SUBMITS a survey.
        * NOTE: We use a Post-Redirect-Get approach to reduce the chances of a double 
        *       survey submission when the customer presses the back button in their browser.
        *
        * TRY: Instead of redirecting to action, try returning view to see our form save duplicate data
        *      into the database.
        */
        // POST: Survey/Index
        // POST: Survey/
        [HttpPost]
        public ActionResult Index(Survey survey)
        {
            // Save the Survey
            surveyDal.SaveSurvey(survey);

            // Redirect the user to the Confirmation Page
            return RedirectToAction("Confirmation");
        }

        /*
        * Controller Action used to show the customer the Confirmation view.
        */
        // GET: Survey/Confirmation        
        public ActionResult Confirmation()
        {
            return View("Confirmation");
        }
    }
}