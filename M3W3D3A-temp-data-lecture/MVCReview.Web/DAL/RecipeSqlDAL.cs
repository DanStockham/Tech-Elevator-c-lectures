using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCReview.Web.Models;
using System.Data.SqlClient;
using Dapper;

namespace MVCReview.Web.DAL
{
    // This class uses Dapper. 
    // It is a Nuget Package that acts as an ORM-Lite (Object Relationship Mapper)
    // Its aim is to reduce the amount of repetitive code written to interact with a database.
    // https://github.com/StackExchange/Dapper
    //
    public class RecipeSqlDAL : IRecipeDAL
    {
        readonly string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Recipes;Integrated Security=True";

        const string SQL_GetRecipes = "SELECT recipe.*, cuisinetype.id as cuisineTypeId, cuisinetype.cuisinetype as cuisinetype FROM recipe INNER JOIN cuisineType ON recipe.cuisineTypeId = cuisineType.id;";
        const string SQL_GetRecipeById = "SELECT recipe.*, cuisinetype.id as cuisineTypeId, cuisinetype.cuisinetype as cuisinetype FROM recipe INNER JOIN cuisineType ON recipe.cuisineTypeId = cuisineType.id WHERE recipe.id = @recipeId;";
        const string SQL_DeleteRecipe = "DELETE FROM recipe WHERE id = @recipeId";
        const string SQL_InsertRecipe = "INSERT INTO recipe VALUES (@name, @description, @cookingTime, @prepTime, @details, @imageName, @cuisineTypeId); SELECT CAST(SCOPE_IDENTITY() as int);";
        const string SQL_UpdateRecipe = "UPDATE recipe SET name = @name, description = @description, cookingTime = @cookingTime, prepTime = @prepTime, details = @details, imageName = @imageName, cuisineTypeId = @cuisineTypeId WHERE id = @recipeId";
        const string SQL_Search = "SELECT recipe.*, cuisinetype.id as cuisineTypeId, cuisinetype.cuisinetype as cuisinetype FROM recipe INNER JOIN cuisineType ON recipe.cuisineTypeId = cuisineType.id WHERE(name LIKE @searchTerm OR description LIKE @searchTerm OR details LIKE @searchTerm OR cuisineType LIKE @searchTerm);";

        public void AddRecipe(Recipe r)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    r.Id = conn.Query<int>(SQL_InsertRecipe, new
                    {
                        name = r.Name,
                        description = r.Description,
                        cookingTime = r.CookingTime,
                        prepTime = r.PrepTime,
                        details = r.Details,
                        imageName = r.ImageName,
                        cuisineTypeId = r.CuisineTypeId
                    }).First();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public void Delete(Recipe r)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    conn.Execute(SQL_DeleteRecipe, new { recipeId = r.Id });
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public void EditRecipe(Recipe r)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    conn.Execute(SQL_UpdateRecipe, new
                    {
                        name = r.Name,
                        description = r.Description,
                        cookingTime = r.CookingTime,
                        prepTime = r.PrepTime,
                        details = r.Details,
                        imageName = r.ImageName,
                        cuisineTypeId = r.CuisineTypeId,
                        recipeId = r.Id
                    });
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public List<Recipe> GetAllRecipes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    List<Recipe> recipes = conn.Query<Recipe>(SQL_GetRecipes).ToList();
                    return recipes;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public Recipe GetRecipe(int recipeId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    Recipe r = conn.QueryFirstOrDefault<Recipe>(SQL_GetRecipeById, new { recipeId = recipeId });
                    return r;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public List<Recipe> Search(string searchTerm)
        {
            searchTerm = "%" + searchTerm + "%";            

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    List<Recipe> matchedRecipes = conn.Query<Recipe>(SQL_Search,
                        new { searchTerm = searchTerm }).ToList();

                    return matchedRecipes;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}