using MVCReview.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCReview.Web.DAL
{
    public interface ICuisineTypeDAL
    {
        List<CuisineType> GetCuisineTypes();
    }
}