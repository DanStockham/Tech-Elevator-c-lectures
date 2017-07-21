using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using HistoryGeek.Web.DataAccess;

namespace HistoryGeek.Web
{
    // ChatConnection is the WebSocket class that we will use.
    // Visitors to our chat site will open a "persistent connection" to this url.
    // Javascript will be used then to notify clients when a new message is broadcast        
    public class ChatConnection : PersistentConnection
    {
        private static Dictionary<string, string> connectedUsers = new Dictionary<string, string>();


        // A new visitor connects
        // We need to add them as a chat member and notify all connected clients
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            string user = request.GetHttpContext().User.Identity.Name;

            if (!connectedUsers.ContainsValue(user))
            {
                connectedUsers[connectionId] = user;
                var broadcastMessage = new {
                    type = "members",
                    values = connectedUsers.Values.Distinct().ToArray()
                };
                Connection.Broadcast(broadcastMessage);
            }
            else
            {
                connectedUsers[connectionId] = user;
            }

            return base.OnConnected(request, connectionId);
        }
        
        // A new visitor disconnects
        // We need to remove them as a chat member and notify all connected clients
        protected override Task OnDisconnected(IRequest request, string connectionId, bool stopCalled)
        {
            if (connectedUsers.ContainsKey(connectionId))
            {
                connectedUsers.Remove(connectionId);
                var broadcastMessage = new
                {
                    type = "members",
                    values = connectedUsers.Values.Distinct().ToArray()
                };
                Connection.Broadcast(broadcastMessage);
            }
            return base.OnDisconnected(request, connectionId, stopCalled);
        }

    }
}