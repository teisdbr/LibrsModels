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

        [JsonProperty("librsIncident")]
        public LibrsIncident LibrsIncident { get; set; }
        
    }
}