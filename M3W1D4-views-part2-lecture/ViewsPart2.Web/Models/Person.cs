using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewsPart2.Web.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Hometown { get; set; }

        public List<string> Interests { get; set; } = new List<string>();
    }
}