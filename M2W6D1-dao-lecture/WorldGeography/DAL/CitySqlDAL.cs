using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CitySqlDAL
    {
        private const string SQL_OhioCities = "SELECT city.id, city.name, city.countrycode, city.district, city.population FROM city WHERE district IN ('Ohio');";
        private const string SQL_CountryCodeCities = "SELECT city.id, city.name, city.countrycode, city.district, city.population FROM city WHERE countryCode = @countrycode ORDER BY city.district, city.name;";
        private string connectionString;

        public CitySqlDAL(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }


        public List<City> GetCitiesByCountryCode(string countryCode)
        {
            List<City> output = new List<City>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_CountryCodeCities, conn);

                    cmd.Parameters.AddWithValue("@countrycode", countryCode);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        City c = new City();
                        c.CityId = Convert.ToInt32(reader["id"]);
                        c.Name = Convert.ToString(reader["name"]);
                        c.CountryCode = Convert.ToString(reader["countrycode"]);
                        c.District = Convert.ToString(reader["district"]);
                        c.Population = Convert.ToInt32(reader["population"]);

                        output.Add(c);
                    }
                }
            }
            catch (SqlException ex)
            {
                //Log and throw the exception
                throw;
            }

            return output;
        }

    }
}
