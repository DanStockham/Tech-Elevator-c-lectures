using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlyByNightBank.Web.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public string CustomerName { get; set; }
        public string State { get; set; }
        public int CustomerExperienceLevel { get; set; }
        public string AdditionalFeedback { get; set; }
        public DateTime SurveySubmissionTimestamp { get; set; }

        public static List<SelectListItem> States
        {
            get
            {
                return new List<SelectListItem>()
                {
                    new SelectListItem { Text = "Ohio", Value = "OH" },
                    new SelectListItem { Text = "Michigan", Value = "MI" },
                    new SelectListItem { Text = "Indiana", Value = "IN" }
                };
            }
        }

        public static List<SelectListItem> SurveyAppreciationLevels
        {
            get
            {
                return new List<SelectListItem>()
                {
                    new SelectListItem { Text = "Outstanding", Value = "5" },
                    new SelectListItem { Text = "Above Average", Value = "4" },
                    new SelectListItem { Text = "Satisfied", Value = "3" },
                    new SelectListItem { Text = "Below Average", Value = "3" },
                    new SelectListItem { Text = "Poor", Value = "1" }
                };
            }
        }
    }
}