using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewsPart3.Web.Models;

namespace ViewsPart3.Web.Controllers
{
    /*
    * Each Controller Action below responds to a request from a browser.
    * If the user visits http://localhost/Home/Index then the
    * Index Action will execute, returning the Index view.
    */
    public class HomeController : Controller
    {

        // GET: Home/Index/Rey
        // GET: Home/Index?id=Rey
        // GET: Home/Index
        // GET: Home/
        // GET: /
        public ActionResult Index(string id)
        {
            // Controllers normally get the model from a database or another part of the code base.
            if (String.IsNullOrEmpty(id))
            {
                id = "luke";
            }

            // Get all available people
            List<Person> existingTeam = GetPersons();
            Person model = null;

            // Loop through the existing team and look for 
            // the person with the firstname equal to id
            foreach (Person p in existingTeam)
            {
                if (p.FirstName.ToLower() == id.ToLower())
                {
                    model = p;
                }
            }

            // Return the View "Index" and pass the model
            return View("Index", model);
        }


        // GET: Home/Colors
        public ActionResult Colors()
        {
            List<string> colorList = new List<string>()
            {
                "Red",
                "Blue",
                "Orange",
                "Green",
                "Black"
            };

            // Return the View "Colors" and pass the colorList as the model
            return View("Colors", colorList);
        }


        // GET: Home/Team
        public ActionResult Team()
        {            
            // Return the View "Team" and pass the team (List<Person>) as the model
            return View("Team", GetPersons());
        }

        // GET: Home/ActionLinkTest
        public ActionResult ActionLinkTest()
        {
            return View();
        }



            private List<Person> GetPersons()
        {
            // Again normally the controller will get this data from another method or class
            List<Person> team = new List<Person>();

            Person luke = new Person() { FirstName = "Luke", LastName = "Skywalker", Hometown = "Tatooine" };
            luke.Interests = new List<string>() { "Flying", "Fixing Droids", "Lightsabers", "Using the Force", "Bullseying Womprats" };

            Person anakin = new Person() { FirstName = "Anakin", LastName = "Skywalker", Hometown = "Tatooine" };
            anakin.Interests = new List<string>() { "Podracing", "Ignoring Obi-Wan", "Getting Angry", "Jedi-Hater", "Padme" };

            Person rey = new Person() { FirstName = "Rey", LastName = "?", Hometown = "Jakku" };
            rey.Interests = new List<string>() { "Scavenging", "Finding Her Parents", "Beating Kylo Ren", "Flying the Falcon", "Saving BB-8" };

            team.Add(luke);
            team.Add(anakin);
            team.Add(rey);

            return team;
        }
    }

}