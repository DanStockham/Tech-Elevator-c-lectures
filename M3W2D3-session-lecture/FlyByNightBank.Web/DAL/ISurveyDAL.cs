using FlyByNightBank.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyByNightBank.Web.DAL
{
    public interface ISurveyDAL
    {
        bool SaveSurvey(Survey newSurvey);
    }
}
