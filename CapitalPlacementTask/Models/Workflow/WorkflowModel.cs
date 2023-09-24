using CapitalPlacementTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Workflow
{
    public class WorkflowModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("programid")]

        public int ProgramId { get; set; }
        [JsonProperty("program")]
        public ProgramDetails Program { get; set; }
        [JsonProperty("stages")]
        public List<Stage> Stages { get; set; }
    }
}
