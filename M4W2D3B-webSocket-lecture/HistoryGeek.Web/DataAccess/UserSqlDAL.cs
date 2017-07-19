using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HistoryGeek.Web.Models;
using Dapper;
using System.Data.SqlClient;

namespace HistoryGeek.Web.DataAccess
{
    public class UserSqlDAL : IUserDAL
    {
        private readonly string connectionString;

        public UserSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public User GetUser(string email)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    User result = conn.QueryFirstOrDefault<User>("SELECT * FROM users WHERE email = @emailValue", new { emailValue = email });
                    return result;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        public void SaveUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    user.Id = conn.QueryFirst<int>("INSERT INTO users VALUES (@emailValue, @passwordValue); SELECT CAST(SCOPE_IDENTITY() as int);",
                        new { emailValue = user.Email, passwordValue = user.Password } );
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}