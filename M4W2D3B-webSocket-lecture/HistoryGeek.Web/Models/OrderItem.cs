using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryGeek.Web.Models
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }        
    }
}