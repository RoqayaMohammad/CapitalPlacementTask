using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Workflow
{
    public class VideoInterview
    {
        [JsonProperty("id")]

        public int id {  get; set; }
        [JsonProperty("evaluatecandidate")]

        public bool EvaluateCandidate { get; set; }
        [JsonProperty("videointerviewquestions")]

        public List<string> VideoInterviewQuestions { get; set; }
        [JsonProperty("additionalinfo")]

        public string AdditionalInformation { get; set; }
        [JsonProperty("maxduration")]

        public int MaxDuration { get; set; }
        [JsonProperty("durationunit")]

        public DurationUnit DurationUnit { get; set; }
        [JsonProperty("deallinedays")]

        public int DeadlineDays { get; set; }
    }
    public enum DurationUnit
    {
        Seconds,
        Minutes
    }
}
