using Newtonsoft.Json;
namespace LibrsModels.Classes
{
    public class LegacyLibrsValues
    {
        [JsonIgnore]
        [JsonProperty("entireLineSegment")]
        public string EntireLineSegment { get; set; }

        [JsonIgnore]
        [JsonProperty("segmentDescriptor")]
        public string SegmentDescriptor { get; set; }

        [JsonIgnore]
        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        [JsonIgnore]
        [JsonProperty("oriNumber")]
        public string ORINumber { get; set; }

        [JsonIgnore]
        [JsonProperty("incidentNumber")]
        public string IncidentNumber { get; set; }

        [JsonIgnore]
        [JsonProperty("expansionBuffer")]
        public string ExpansionBuffer { get; set; }

        [JsonIgnore]
        [JsonProperty("segmentEnd")]
        public string SegmentEnd = "ZZ";

        [JsonIgnore]
        [JsonProperty("padding")]
        public string Padding { get; set; }
    }
}