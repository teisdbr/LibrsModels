using Newtonsoft.Json;
namespace LibrsModels.Classes
{
    public class LegacyLibrsValues
    {
        [JsonProperty("entireLineSegment")]
        public string EntireLineSegment {internal get; set; }
        
        [JsonProperty("segmentDescriptor")]
        public string SegmentDescriptor {internal get; set; }
        
        [JsonProperty("actionType")]
        public string ActionType { internal get; set; }
        
        [JsonProperty("oriNumber")]
        public string ORINumber {internal get; set; }
        
        [JsonProperty("incidentNumber")]
        public string IncidentNumber {internal get; set; }
        
        [JsonProperty("expansionBuffer")]
        public string ExpansionBuffer {internal get; set; }
        
        [JsonProperty("segmentEnd")]
        public string SegmentEnd {internal get; set; } = "ZZ";

        [JsonProperty("padding")]
        public string Padding {internal get; set; }
    }
}