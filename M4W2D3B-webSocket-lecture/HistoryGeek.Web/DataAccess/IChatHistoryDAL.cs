using HistoryGeek.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryGeek.Web.DataAccess
{
    public interface IChatHistoryDAL
    {
        /// <summary>
        /// Retrieves the most recent chat messages
        /// </summary>
        /// <param name="limit">Amount of most recent messages to receive (e.g. last 10)</param>
        /// <returns></returns>
        List<ChatMessage> GetChatMessages(int limit);

        
        /// <summary>
        /// Saves a new chat message
        /// </summary>        
        void SaveChatMessage(ChatMessage message);
    }
}
