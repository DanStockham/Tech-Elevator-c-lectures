using FlyByNightBank.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlyByNightBank.Web.DAL
{
    public interface IApplicationDAL
    {
        bool SubmitApplication(LoanApplication newLoanApplication);
    }
}