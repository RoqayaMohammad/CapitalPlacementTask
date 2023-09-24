using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CapitalPlacementTask.Models
{
    public class ProgramDetails
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("prgramtitle")]
        [Required]
        public string ProgramTitle { get; set; }
        [JsonProperty("summary")]
        [MaxLength(250)]
        public string Summary { get; set; }
        [JsonProperty("description")]
        [Required]
        public string Description { get; set; }
        [JsonProperty("keyskillsrequried")]
        public string KeySkillsRequired { get; set; }
        [JsonProperty("programbenefits")]
        public string ProgramBenefits { get; set; }
        [JsonProperty("description")]
        public string ApplicationCriteria { get; set; }
       

        //
        [Required]
        [JsonProperty("programtype")]
        public ProgramType ProgramType { get; set; }
        [JsonProperty("appopendate")]
        [Required]
        public DateTime ApplicationOpenDate { get; set; }
        [JsonProperty("appclosedate")]
        [Required]
        public DateTime ApplicationCloseDate { get; set; }
        [JsonProperty("duration")]
        public string Duration { get; set; }
        [JsonProperty("minqualifications")]
        public string MinQualifications { get; set; }
        [JsonProperty("prgramstart")]
        public DateTime ProgramStart { get; set; }
        [JsonProperty("prgramlocation")]
        [Required]
        public string ProgramLocation { get; set; }
        [JsonProperty("isfullyremote")]
        [Required]
        public bool IsFullyRemote { get; set; }
        [JsonProperty("maxquals")]
        public int MaxNumberOfQualifications { get; set; }
    }

    public enum ProgramType
    {
        FullTime,
        PartTime,
        Internship
    }
}
