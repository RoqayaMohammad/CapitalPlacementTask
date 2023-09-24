using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.ApplicationForm
{
    public class PersonalInformation
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("firstname")]
        public string FirstName { get; set; }
        [JsonProperty("lastname")]
        public string LastName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("Isphoneinternal")]
        public bool IsPhoneInternal { get; set; }
        [JsonProperty("nationality")]
        public string Nationality { get; set; }
        [JsonProperty("isnationalityinternal")]
        public bool IsNationalityInternal { get; set; }
        [JsonProperty("currentresidence")]
        public string CurrentResidence { get; set; }
        [JsonProperty("iscurrentresidenceinternal")]
        public bool IsCurrentResidenceInternal { get; set; }
        [JsonProperty("idnum")]
        public string IDNumber { get; set; }
        [JsonProperty("isidnuminternal")]
        public bool IsIDNumberInternal { get; set; }
        [JsonProperty("dateofbirth")]
        public DateTime DateOfBirth { get; set; }
        [JsonProperty("isdateofbithinternal")]
        public bool IsDateOfBirthInternal { get; set; }
        [JsonProperty("gender")]
        public Gender Gender { get; set; }
        [JsonProperty("isgenderinternal")]
        public bool IsGenderInternal { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
}
