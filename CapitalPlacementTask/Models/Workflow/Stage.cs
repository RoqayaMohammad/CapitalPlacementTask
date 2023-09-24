using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Workflow
{
    public class Stage
    {
        [JsonProperty("id")]
        public string StageName { get; set; }
        [JsonProperty("stagetype")]
        public StageType Type { get; set; }
        [JsonProperty("donotshowtocandidate")]
        public bool DoNotShowToCandidate { get; set; }
        [JsonProperty("videointerview")]

        public VideoInterview VideoInterview { get; set; }
    }
    public enum StageType
    {
        Shortlisting,
        VideoInterview,
        Placement
    }
}
