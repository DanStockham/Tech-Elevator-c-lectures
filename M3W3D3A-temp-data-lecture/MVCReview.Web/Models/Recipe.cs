using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCReview.Web.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CookingTime { get; set; }
        public int PrepTime { get; set; }
        public string Details { get; set; }
        public string ImageName { get; set; }
        
        // Related Properties thru Join Table
        public int CuisineTypeId { get; set; }
        public string CuisineType { get; set; }

        public List<SelectListItem> CuisineTypes { get; set; }
    }
}