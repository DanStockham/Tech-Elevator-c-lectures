using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace WebApplication3.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public bool LicensedDriver { get; set; }
        public string FavoriteColor { get; set; }

        public override string ToString()
        {
            return (FirstName.PadRight(20) + LastName.PadRight(20)
                + LicensedDriver.ToString().PadRight(20) + BirthYear.ToString().PadRight(20)
                + FavoriteColor.ToString().PadRight(20));
        }
    }
}