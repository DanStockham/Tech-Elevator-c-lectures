using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryGeek.Web.Models
{
    public class ShoppingCartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public double Price
        {
            get
            {
                return Product.Price * Quantity;
            }
        }

        public double Weight
        {
            get
            {
                return Product.Weight * Quantity;
            }
        }
    }
}