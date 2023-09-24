using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.ApplicationForm
{
    public class Profile
    {
        [JsonProperty("educationmandatory")]
        public bool EducationMandatory { get; set; }
        [JsonProperty("educationbuttonenable")]
        public bool ShowEducationButton { get; set; }
        [JsonProperty("educations")]
        public List<Education> Educations { get; set; } // References to Education forms
        [JsonProperty("experiencemandatory")]
        public bool ExperienceMandatory { get; set; }
        [JsonProperty("experiencebuttonenable")]
        public bool ShowExperienceButton { get; set; }
        [JsonProperty("experiences")]
        public List<Experience> Experiences { get; set; } // References to Work Experience forms
        [JsonProperty("resumemandatory")]
        public bool ResumeMandatory { get; set; }
        [JsonProperty("showresumebutton")]

        public bool ShowResumeButton { get; set; }
       
    }
}
