using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace LibrsModels.Classes
{
    public class RootValidationObject
    {
        [JsonProperty("spec")] public string Spec { get; set; }

        [JsonProperty("ori")] public string Ori { get; set; }

        [JsonProperty("reportYear")] public int ReportYear { get; set; }

        [JsonProperty("reportMonth")] public int ReportMonth { get; set; }

        [JsonProperty("forSubmission")] public bool ForSubmission { get; set; }

        [JsonProperty("librsIncident")] public List<LibrsIncident> IncidentList { get; set; }
        
    }
}