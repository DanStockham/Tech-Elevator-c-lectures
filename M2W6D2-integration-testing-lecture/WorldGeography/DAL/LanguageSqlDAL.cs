using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class LanguageSqlDAL
    {
        private string connectionString;
        private const string SQL_InsertLanguage = @"insert into countrylanguage values (@countryCode, @language, @isOfficial, @percentage);";
        private const string SQL_LanguagesByCountry = @"select *  from countrylanguage  where countrycode = @countryCode and isofficial = @isOfficial;";
        private const string SQL_DeleteLanguage = "DELETE FROM countryLanguage WHERE countryCode = @countryCode AND language = @language";



        public LanguageSqlDAL(string databaseConnectionString)
        {
            connectionString = databaseConnectionString;
        }

        public List<Language> GetLanguages(string countryCode, bool officialOnly)
        {
            List<Language> output = new List<Language>();

            try
            {
                //Create my connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    //Create the command
                    SqlCommand cmd = new SqlCommand(SQL_LanguagesByCountry, conn);

                    //Add parameters to my command
                    cmd.Parameters.AddWithValue("@countryCode", countryCode);
                    cmd.Parameters.AddWithValue("@isOfficial", officialOnly);

                    //execute the command
                    SqlDataReader reader = cmd.ExecuteReader();

                    //Read each row and turn it into an object
                    while (reader.Read())
                    {
                        Language l = new Language();
                        l.CountryCode = Convert.ToString(reader["countryCode"]);
                        l.Name = Convert.ToString(reader["language"]);
                        l.IsOfficial = Convert.ToBoolean(reader["isOfficial"]);
                        l.Percentage = Convert.ToInt32(reader["percentage"]);

                        output.Add(l);
                    }
                }

            }
            catch (SqlException e)
            {
                //log 
                throw;
            }


            return output;
        }

        public bool AddNewLanguage(Language newLanguage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_InsertLanguage, conn);
                    cmd.Parameters.AddWithValue("@countryCode", newLanguage.CountryCode);
                    cmd.Parameters.AddWithValue("@language", newLanguage.Name);
                    cmd.Parameters.AddWithValue("@isOfficial", newLanguage.IsOfficial);
                    cmd.Parameters.AddWithValue("@percentage", newLanguage.Percentage);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0); //true if one row was affected
                }
            }
            catch (SqlException ex)
            {
                //log
                throw;
            }
        }

        public bool RemoveLanguage(Language deadLanguage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_DeleteLanguage, conn);
                    cmd.Parameters.AddWithValue("@countryCode", deadLanguage.CountryCode);
                    cmd.Parameters.AddWithValue("@language", deadLanguage.Name);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}
