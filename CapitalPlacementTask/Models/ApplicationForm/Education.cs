using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.ApplicationForm
{
    public class Education
    {

        [JsonProperty("school")]
        public string School { get; set; }
        [JsonProperty("degree")]
        public string Degree { get; set; }
        [JsonProperty("coursename")]
        public string CourseName { get; set; }
        [JsonProperty("locaton")]
        public string Location { get; set; }
        [JsonProperty("startdate")]
        public DateTime StartDate { get; set; }
        [JsonProperty("enddate")]
        public DateTime? EndDate { get; set; }
        [JsonProperty("currentlystudying")]
        public bool CurrentlyStudying { get; set; }
    }
}
