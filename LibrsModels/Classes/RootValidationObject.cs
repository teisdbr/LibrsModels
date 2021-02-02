using Newtonsoft.Json;
using System.Collections.Generic;

namespace LibrsModels.Classes
{
    public class RootValidationObject
    {
        [JsonProperty("spec")]
        public string Spec { get; set; }

        [JsonProperty("ori")]
        public string Ori { get; set; }

        [JsonProperty("reportYear")]
        public int ReportYear { get; set; }

        [JsonProperty("reportMonth")]
        public int ReportMonth { get; set; }

        [JsonProperty("forSubmission")]
        public bool ForSubmission { get; set; }

        [JsonProperty("incidentList")]
        public List<BaseLibrsIncident> IncidentList { get; set; }
    }
}