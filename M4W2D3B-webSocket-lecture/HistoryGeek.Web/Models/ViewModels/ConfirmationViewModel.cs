using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryGeek.Web.Models.ViewModels
{
    public class ConfirmationViewModel
    {
        public Order Order { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<Product> Products { get; set; }
    }
}