using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CountrySqlDAL 
    {
        private string connectionString;
        private const string SQL_GetContinentNames = "SELECT DISTINCT continent FROM country";

        //Constructor
        public CountrySqlDAL(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        // Returns a List<string> that contains the unique continent names in the world database.
        public List<string> GetContinentNames()
        {
            List<string> output = new List<string>();

            //Always wrap connection to a database in a try-catch block
            try
            {
                //Create a SqlConnection to our database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = SQL_GetContinentNames;
                    cmd.Connection = connection;

                    // Execute the query to the database
                    SqlDataReader reader = cmd.ExecuteReader();

                    // The results come back as a SqlDataReader. Loop through each of the rows
                    // and add to the output list
                    while (reader.Read())
                    {
                        // Read in the value from the reader
                        // Reference by index or by column_name
                        string continent = Convert.ToString(reader["continent"]);

                        // Add the continent to the output list
                        output.Add(continent);
                    }
                }
            }
            catch (SqlException ex)
            {
                // A SQL Exception Occurred. Log and throw to our application!!
                throw;
            }

            // Return the list of continents
            return output;
        }


        public List<Country> GetCountriesInNorthAmerica()
        {
            List<Country> output = new List<Country>();

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM country WHERE continent='North America'", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Country c = new Country();
                        c.Code = Convert.ToString(reader["code"]);
                        c.Name = Convert.ToString(reader["name"]);
                        c.Continent = Convert.ToString(reader["continent"]);
                        c.Region = Convert.ToString(reader["region"]);
                        c.SurfaceArea = Convert.ToDouble(reader["surfacearea"]);
                        c.Population = Convert.ToInt32(reader["population"]);
                        c.GovernmentForm = Convert.ToString(reader["governmentform"]);

                        output.Add(c);
                    }
                }
            }
            catch(SqlException ex)
            {
                // Log 
                throw;
            }

            return output;
        }
    }
}
