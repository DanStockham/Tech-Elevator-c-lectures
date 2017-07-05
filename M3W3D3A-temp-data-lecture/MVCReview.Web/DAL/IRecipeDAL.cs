using MVCReview.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCReview.Web.DAL
{
    public interface IRecipeDAL
    {
        List<Recipe> GetAllRecipes();
        Recipe GetRecipe(int recipeId);

        void EditRecipe(Recipe r);
        void AddRecipe(Recipe r);
        void Delete(Recipe r);

        List<Recipe> Search(string searchTerm);
    }
}