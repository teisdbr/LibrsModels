using System.Collections.Generic;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class ArrStatute: OldLibrsValues
    {
        
        [JsonProperty("arrestSeqNum")]
        public string ArrestSeqNum { get; set; }
        
        [JsonProperty("arrestConToOffense")]
        public string ArrestConToOffense { get; set; }
        
        [JsonProperty("arresteInchoate")]
        public string ArresteInchoate { get; set; }
        
        [JsonProperty("agencyAssignedNibrs")]
        public string AgencyAssignedNibrs { get; set; }

        [JsonIgnore]
        public List<ValidateLars> ValidateLars { get; set; }

        [JsonIgnore]
        public List<FbiValidate> FbiValidates { get; set; }
        
        [JsonProperty("lrsNumber")]
        public string LrsNumber { get; set; }

        [JsonIgnore]
        public bool? OfficerDidAssignNibrs { get; set; }
        
        [JsonProperty("inchoate")]
        public object Inchoate { get; set; }
        
        [JsonProperty("offenseGroup")]
        public string OffenseGroup { get; set; }
    }
}