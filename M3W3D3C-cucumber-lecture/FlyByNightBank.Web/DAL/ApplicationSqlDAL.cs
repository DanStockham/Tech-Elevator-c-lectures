using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlyByNightBank.Web.Models;
using System.Data.SqlClient;

namespace FlyByNightBank.Web.DAL
{
    public class ApplicationSqlDAL : IApplicationDAL
    {
        private const string SQL_InsertApplication = @"INSERT INTO loan_applications 
            VALUES (@first_name, @last_name, @logon_username, @home_address, @home_city, @home_state, @home_postalCode,
                    @home_phone, @job_title, @work_address, @work_city, @work_state, @work_postalCode, @work_phone,
                    @net_worth, @reference1_name, @reference1_phone, @date_submitted); SELECT CAST(SCOPE_IDENTITY() as int);";
        private readonly string connectionString;

        public ApplicationSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public bool SubmitApplication(LoanApplication newLoanApplication)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_InsertApplication, conn);
                    cmd.Parameters.AddWithValue("@first_name", newLoanApplication.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", newLoanApplication.LastName);
                    cmd.Parameters.AddWithValue("@logon_username", newLoanApplication.LogonUsername);

                    cmd.Parameters.AddWithValue("@home_address", newLoanApplication.HomeAddress);
                    cmd.Parameters.AddWithValue("@home_city", newLoanApplication.HomeCity);
                    cmd.Parameters.AddWithValue("@home_state", newLoanApplication.HomeState);
                    cmd.Parameters.AddWithValue("@home_postalCode", newLoanApplication.HomePostalCode);
                    cmd.Parameters.AddWithValue("@home_phone", newLoanApplication.HomePhone);

                    if (String.IsNullOrEmpty(newLoanApplication.JobTitle))
                    {
                        cmd.Parameters.AddWithValue("@job_title", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@job_title", newLoanApplication.JobTitle);
                    }

                    if (String.IsNullOrEmpty(newLoanApplication.WorkAddress))
                    {
                        cmd.Parameters.AddWithValue("@work_address", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@work_address", newLoanApplication.WorkAddress);
                    }

                    if (String.IsNullOrEmpty(newLoanApplication.WorkCity))
                    {
                        cmd.Parameters.AddWithValue("@work_city", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@work_city", newLoanApplication.WorkCity);
                    }

                    if (String.IsNullOrEmpty(newLoanApplication.WorkState))
                    {
                        cmd.Parameters.AddWithValue("@work_state", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@work_state", newLoanApplication.WorkState);
                    }

                    if (String.IsNullOrEmpty(newLoanApplication.WorkPostalCode))
                    {
                        cmd.Parameters.AddWithValue("@work_postalCode", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@work_postalCode", newLoanApplication.WorkPostalCode);
                    }


                    if (String.IsNullOrEmpty(newLoanApplication.WorkPhone))
                    {
                        cmd.Parameters.AddWithValue("@work_phone", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@work_phone", newLoanApplication.WorkPhone);
                    }


                    cmd.Parameters.AddWithValue("@net_worth", newLoanApplication.NetWorth);
                    cmd.Parameters.AddWithValue("@reference1_name", newLoanApplication.Reference1Name);
                    cmd.Parameters.AddWithValue("@reference1_phone", newLoanApplication.Reference1Phone);

                    newLoanApplication.DateSubmitted = DateTime.UtcNow;
                    cmd.Parameters.AddWithValue("@date_submitted", newLoanApplication.DateSubmitted);

                    int newId = (int)cmd.ExecuteScalar();

                    newLoanApplication.ApplicationId = newId;

                    return true;
                }
            }
            catch (SqlException ex)
            {
                // Log the Exception so that someone can be notified.
                return false;
            }
        }
    }
}