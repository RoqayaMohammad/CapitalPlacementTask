using CapitalPlacementTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.ApplicationForm
{
    public class ApplicationPage
    {
        public int id { get; set; }

        public int ProgramId { get; set; }
        public virtual ProgramDetails ProgramDetails { get; set; }
        public byte[] CoverImage { get; set; } 
        public PersonalInformation PersonalInformation { get; set; }
        public Profile Profile { get; set; }
        public bool RejectedByUKEmbassy { get; set; }
    }
}
