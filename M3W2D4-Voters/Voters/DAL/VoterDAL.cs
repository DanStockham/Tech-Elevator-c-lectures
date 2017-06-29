using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Voters.Models;

namespace Voters.DAL
{
    public class VoterDAL

    {
        private string connectionString;
        private const string SQL_GetVotersByLastName = "SELECT * FROM voter WHERE LASTNAME = @lastNAme;";
        private const string SQL_GetVoterById = "SELECT * FROM voter WHERE [VOTER ID] = @id;";

        public VoterDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }


        
             public Voter GetVoterById(string id)
        {
 
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetVoterById, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();
                    Voter voter = new Voter();

                    while (reader.Read())
                    {
                        MoveFields(reader, voter);
                    }
                    return voter;
                }
            }
            catch (SqlException ex)
            {
                // Error Logging that a problem occurred, don't show the user
                throw;
            }
        }


        public List<Voter> GetVotersByLastName(string lastName)
        {
            List<Voter> voters = new List<Voter>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetVotersByLastName, conn);
                    cmd.Parameters.AddWithValue("@lastName", lastName);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Voter voter = new Voter();
                        MoveFields(reader, voter);
                        voters.Add(voter);
                    }
                }

                return voters;
            }
            catch (SqlException ex)
            {
                // Error Logging that a problem occurred, don't show the user
                throw;
            }
        }

        private void MoveFields(SqlDataReader reader, Voter voter)
        {
            voter.Id = Convert.ToString(reader["VOTER ID"]);
            voter.LastName = Convert.ToString(reader["LASTNAME"]);
            voter.FirstName = Convert.ToString(reader["FIRSTNAME"]);
            voter.StreetName = Convert.ToString(reader["RES_STREET"]);
            voter.YearOfBirth = Convert.ToString(reader["DATE OF BIRTH"]);
        }
    }
}
