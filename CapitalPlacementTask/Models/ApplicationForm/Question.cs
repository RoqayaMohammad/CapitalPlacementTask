using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.ApplicationForm
{
    public class Question
    {
        [JsonProperty("id")]

        public int Id { get; set; }
        [JsonProperty("type")]

        public QuestionType Type { get; set; }
        [JsonProperty("qustiontext")]

        public string QuestionText { get; set; }
        [JsonProperty("ismandatory")]

        public bool IsMandatory { get; set; }
        [JsonProperty("choices")]

        public List<string> Choices { get; set; }
        [JsonProperty("maxchoices")]

        public int? MaxChoices { get; set; }
        [JsonProperty("enbleotheroption")]

        public bool? EnableOtherOption { get; set; }
        [JsonProperty("disqualifyifno")]

        public bool? DisqualifyIfNo { get; set; }


        public Question(QuestionType type)
        {
            Type = type;

            
            switch (type)
            {
                case QuestionType.Paragraph:
                    MaxChoices = null;
                    EnableOtherOption = null;
                    DisqualifyIfNo = null;
                    break;

                case QuestionType.MultipleChoice:
                    MaxChoices = null;
                    EnableOtherOption = null;
                    DisqualifyIfNo = null;
                    break;

                case QuestionType.Dropdown:
                    MaxChoices = null;
                    EnableOtherOption = false;
                    DisqualifyIfNo = null;
                    break;

                case QuestionType.YesNo:
                    MaxChoices = null;
                    EnableOtherOption = null;
                    DisqualifyIfNo = true;
                    break;
            }
        }
    }
    public enum QuestionType
    {
        Paragraph,
        MultipleChoice,
        Dropdown,
        YesNo
    }
}
