using Dapper;
using MVCReview.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCReview.Web.DAL
{
    // This class uses Dapper. 
    // It is a Nuget Package that acts as an ORM-Lite (Object Relationship Mapper)
    // Its aim is to reduce the amount of repetitive code written to interact with a database.
    // https://github.com/StackExchange/Dapper
    //
    public class CuisineTypeSqlDAL : ICuisineTypeDAL
    {
        readonly string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Recipes;Integrated Security=True";
        const string SQL_GetCulinaryTypes = "SELECT id, cuisineType as name FROM cuisineType;";

        public List<CuisineType> GetCuisineTypes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    var cuisineTypes = conn.Query<CuisineType>(SQL_GetCulinaryTypes).ToList();                        

                    return cuisineTypes;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}