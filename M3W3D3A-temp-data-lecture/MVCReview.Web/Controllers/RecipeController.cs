using MVCReview.Web.DAL;
using MVCReview.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReview.Web.Controllers
{
    public class RecipeController : Controller
    {
        private IRecipeDAL recipeDal;
        private ICuisineTypeDAL cuisineTypeDal;

        public RecipeController(IRecipeDAL recipeDal, ICuisineTypeDAL cuisineTypeDal)
        {
            this.recipeDal = recipeDal;
            this.cuisineTypeDal = cuisineTypeDal;
        }

        // GET: Recipe/Search
        public ActionResult Search()
        {
            return View("Search");
        }

        // GET: Recipe/SearchResult
        public ActionResult SearchResult(string searchTerm)
        {
            List<Recipe> matchedRecipes = recipeDal.Search(searchTerm);
            return View("SearchResult", matchedRecipes);
        }

        // GET: Recipe
        public ActionResult Index()
        {
            return View();
        }

        // GET: Recipe/New
        public ActionResult New()
        {
            // Go to the database to get the cuisine Types
            List<CuisineType> cuisineTypes = cuisineTypeDal.GetCuisineTypes();
            Recipe model = new Recipe();

            // Convert the cuisine types to select list items
            model.CuisineTypes = ConvertListToSelectList(cuisineTypes);

            return View("New", model);
        }

        [HttpPost]
        public ActionResult New(Recipe r, HttpPostedFileBase uploadedImage)
        {
            if (uploadedImage != null)
            {
                string fileName = System.IO.Path.GetFileName(uploadedImage.FileName);
                string path = System.IO.Path.Combine(
                                       Server.MapPath("~/images/recipe"), fileName);

                // Save
                uploadedImage.SaveAs(path);
                r.ImageName = fileName;
            }

            recipeDal.AddRecipe(r);

            //Save in Session that they just created a recipe
            TempData["StatusMessage"] = "Success! Your recipe was successfully added!";

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(int id)
        {
            Recipe r = recipeDal.GetRecipe(id);

            if (r == null)
            {
                return HttpNotFound();
            }


            List<CuisineType> cuisineTypes = cuisineTypeDal.GetCuisineTypes();
            r.CuisineTypes = ConvertListToSelectList(cuisineTypes);

            return View("Edit", r);
        }

        [HttpPost]
        public ActionResult Edit(Recipe r, HttpPostedFileBase uploadedImage)
        {
            if (uploadedImage != null)
            {
                string fileName = System.IO.Path.GetFileName(uploadedImage.FileName);
                string path = System.IO.Path.Combine(
                                       Server.MapPath("~/images/recipe"), fileName);

                // Save
                uploadedImage.SaveAs(path);
                r.ImageName = fileName;
            }

            recipeDal.EditRecipe(r);

            //Save in Session that they just updated a recipe
            TempData["StatusMessage"] = "Success! Your recipe was successfully updated!";


            return RedirectToAction("Index", "Home");
        }

        private List<SelectListItem> ConvertListToSelectList(List<CuisineType> cuisineTypes)
        {
            List<SelectListItem> dropdownlist = new List<SelectListItem>();

            foreach (CuisineType ct in cuisineTypes)
            {
                SelectListItem choice = new SelectListItem() { Text = ct.Name, Value = ct.Id.ToString() };
                dropdownlist.Add(choice);
            }

            return dropdownlist;
        }

        
    }
}