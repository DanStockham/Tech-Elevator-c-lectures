using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlyByNightBank.Web.Models
{
    public class LoanApplication
    {
        public int ApplicationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LogonUsername { get; set; }

        public string HomeAddress { get; set; }
        public string HomeCity { get; set; }
        public string HomeState { get; set; }
        public string HomePostalCode { get; set; }
        public string HomePhone { get; set; }

        public string JobTitle { get; set; }
        public string WorkAddress { get; set; }
        public string WorkCity { get; set; }
        public string WorkState { get; set; }
        public string WorkPostalCode { get; set; }
        public string WorkPhone { get; set; }

        public decimal NetWorth { get; set; }
        public string Reference1Name { get; set; }
        public string Reference1Phone { get; set; }

        public DateTime DateSubmitted { get; set; }
    }
}