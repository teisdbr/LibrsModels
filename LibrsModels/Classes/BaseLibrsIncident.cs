using System.Collections.Generic;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class BaseLibrsIncident
    {
        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        [JsonProperty("incidentNumber")]
        public string IncidentNumber { get; set; }

        [JsonProperty("incidentList")]
        public List<LibrsIncident> IncidentList { get; set; }
        
    }
}