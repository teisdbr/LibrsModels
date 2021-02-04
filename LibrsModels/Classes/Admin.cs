using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class Admin : OldLibrsValues
    {
        [JsonProperty("location")] public string Location { get; set; } = "            ";

        [JsonProperty("stationID")] public string StationID { get; set; } = "      ";

        [JsonProperty("incidentDate")] public string IncidentDate { get; set; } = "           ";

        [JsonProperty("clearedExceptionally")] public string ClearedExceptionally { get; set; } = "N";

        [JsonProperty("excpClearDate")] public string ExcpClearDate { get; set; } = "        ";

        [JsonIgnore] public object HasGroupAOffense { get; set; }
        
        public Admin()
        {
            SegmentDescriptor = "10";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 84));
        }
    }
}