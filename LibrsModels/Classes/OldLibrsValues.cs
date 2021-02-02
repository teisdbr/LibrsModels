using Newtonsoft.Json;
namespace LibrsModels.Classes
{
    public class OldLibrsValues
    {
        [JsonIgnore]
        public string EntireLineSegment { get; set; }

        [JsonIgnore]
        public string SegmentDescriptor { get; set; }

        [JsonIgnore]
        public string ActionType { get; set; }

        [JsonIgnore]
        public string ORINumber { get; set; }

        [JsonIgnore]
        public string IncidentNumber { get; set; }

        [JsonIgnore]
        public string ExpansionBuffer { get; set; }

        [JsonIgnore]
        public string SegmentEnd = "ZZ";

        [JsonIgnore]
        public string Padding { get; set; }
    }
}