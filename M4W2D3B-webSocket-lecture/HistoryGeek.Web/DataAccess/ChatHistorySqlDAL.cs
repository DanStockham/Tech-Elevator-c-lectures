using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HistoryGeek.Web.Models;
using System.Data.SqlClient;
using Dapper;

namespace HistoryGeek.Web.DataAccess
{
    public class ChatHistorySqlDAL : IChatHistoryDAL
    {
        private readonly string connectionString;

        public ChatHistorySqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<ChatMessage> GetChatMessages(int limit)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    var messages = conn.Query<ChatMessage>(@"SELECT TOP (@limitValue) chat_history.id, userId, message, sentDate, users.email AS username
                        FROM chat_history INNER JOIN users ON chat_history.userId = users.id ORDER BY sentDate", new { limitValue = limit });

                    return messages.ToList();
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }

        

        public void SaveChatMessage(ChatMessage message)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();                    

                    conn.Execute("INSERT INTO chat_history VALUES (@userIdValue, @messageValue, @messageDate)",
                        new { userIdValue = message.UserId, messageValue = message.Message, messageDate = message.SentDate });

                    
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
        }
    }
}