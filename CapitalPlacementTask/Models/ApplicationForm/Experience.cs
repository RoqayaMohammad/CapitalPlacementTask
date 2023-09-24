using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.ApplicationForm
{
    public class Experience
    {
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
        [JsonProperty("startdate")]
        public DateTime StartDate { get; set; }
        [JsonProperty("enddate")]
        public DateTime? EndDate { get; set; }
        [JsonProperty("currentlyworking")]
        public bool CurrentlyWorking { get; set; }
    }
}
