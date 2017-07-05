using MVCReview.Web.DAL;
using MVCReview.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReview.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRecipeDAL recipeDal;

        public HomeController(IRecipeDAL recipeDal)
        {
            this.recipeDal = recipeDal;
        }


        // GET: Home
        public ActionResult Index()
        {
            List<Recipe> recipes = recipeDal.GetAllRecipes();

            return View("Index", recipes);
        }
    }
}