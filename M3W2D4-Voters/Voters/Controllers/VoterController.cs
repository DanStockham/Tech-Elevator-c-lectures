using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Voters.DAL;
using Voters.Models;

namespace Voters.Controllers
{


    public class VoterController : Controller
    {
        string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Voters;Integrated Security=True";

        // GET: Voter
        public ActionResult Index()
        {
            return View();
        }

        // GET: Lookup
        public ActionResult Lookup(string LastName)
        {
            VoterDAL voterData = new VoterDAL(connectionString);
            List<Voter> voters = voterData.GetVotersByLastName(LastName);
            if (voters.Count == 0)
            {
                //return to index
                ViewBag.InformationMessage = "No records found.";
                return View("Index");
            }
            else if (voters.Count == 1)
            {
                //first and only
                Voter voter = voters.First();
                return View("Details", voter);
            }
            else
            {
                // send the list
                return View("List", voters);
            }

            return View();
        }

        // GET: Detail
        public ActionResult Details(String Id)
        {
            VoterDAL voterData = new VoterDAL(connectionString);
            Voter voter = voterData.GetVoterById(Id);
            return View("Details", voter);
        }
    }
}