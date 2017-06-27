using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlyByNightBank.Web.Models;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace FlyByNightBank.Web.DAL
{
    public class SurveySqlDAL 
    {
        private string connectionString;

        private const string SQL_InsertSurvey = "INSERT INTO customer_surveys VALUES (@customerName, @state, @customer_experience, @additional_feedback, @survey_submitted);";

        public SurveySqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool SaveSurvey(Survey newSurvey)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_InsertSurvey, conn);
                    cmd.Parameters.AddWithValue("@customerName", newSurvey.CustomerName);
                    cmd.Parameters.AddWithValue("@state", newSurvey.State);
                    cmd.Parameters.AddWithValue("@customer_experience", newSurvey.CustomerExperienceLevel);
                    cmd.Parameters.AddWithValue("@additional_feedback", newSurvey.AdditionalFeedback);
                    cmd.Parameters.AddWithValue("@survey_submitted", DateTime.UtcNow);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch(SqlException ex)
            {
                // Error Logging that a problem occurred, don't show the user
                throw;
            }
        }
    }
}