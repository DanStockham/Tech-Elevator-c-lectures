using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HistoryGeek.Web.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }       

        [Required]
        public string Message { get; set; }        
        public DateTime SentDate { get; set; }


        public string Username { get; set; } //<-- this property is retrieved by joining with the users table
    }
}