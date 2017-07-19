using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HistoryGeek.Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageName { get; set; }
        public double Weight { get; set; }
        public bool Active { get; set; }

        public int Pounds
        {
            get
            {
                return (int)Weight / 16;
            }
        }
        public int Ounces
        {
            get
            {
                return (int)Weight % 16;
            }
        }
    }
}