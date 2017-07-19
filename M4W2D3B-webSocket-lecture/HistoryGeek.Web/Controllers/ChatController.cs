using HistoryGeek.Web.DataAccess;
using HistoryGeek.Web.Models;
using HistoryGeek.Web.Models.ViewModels;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HistoryGeek.Web.Controllers
{
    // Chat Controller manages the logic for displaying chat history and saving chat messages.
    public class ChatController : Controller
    {
        private readonly IChatHistoryDAL chatHistoryDal;
        private readonly IUserDAL userDal;

        public ChatController(IChatHistoryDAL chatHistoryDal, IUserDAL userDal)
        {
            this.chatHistoryDal = chatHistoryDal;
            this.userDal = userDal;
        }

        // Used to make sure that the user has "logged in" before chatting.
        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    if (Session[SessionKeys.Username] == null)
        //    {
        //        filterContext.Result = RedirectToAction("Login", "User");
        //    }
        //}

        // GET: Chat/
        // Users must have logged in to visit the chat page.
        [System.Web.Mvc.Authorize]
        public ActionResult Index()
        {
            List<ChatMessage> messages = chatHistoryDal.GetChatMessages(20); //last 20 chat messages
            return View("Index", messages);
        }

        // POST: Chat/
        [HttpPost]
        [System.Web.Mvc.Authorize]
        public ActionResult Index(string message)
        {
            if (!String.IsNullOrEmpty(message))
            {
                // Get the user who sent in the request
                User user = userDal.GetUser((string)Session[SessionKeys.Username]);
                ChatMessage chatMessage = new ChatMessage()
                {
                    Message = message,
                    UserId = user.Id,
                    Username = user.Email,
                    SentDate = DateTime.UtcNow
                };

                // Save the chat message
                chatHistoryDal.SaveChatMessage(chatMessage);

                // Use the SignalR library to "Broadcast" the message to all listening users
                var chatConnectionContext = GlobalHost.ConnectionManager.GetConnectionContext<ChatConnection>();
                var broadcastMessage = new
                {
                    type = "newmessage",
                    values = chatMessage
                };
                chatConnectionContext.Connection.Broadcast(broadcastMessage);
            }

            return RedirectToAction("Index");
        }


    }
}