using System;
using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class Admin : LegacyLibrsValues, IPaddingFixer
    {
        [JsonProperty("location")] public string Location { get; set; } = "            ";

        [JsonProperty("stationID")] public string StationID { get; set; } = "      ";

        [JsonProperty("incidentDate")] public DateTime IncidentDate { get; set; }

        [JsonProperty("clearedExceptionally")] public string ClearedExceptionally { get; set; } = "N";

        [JsonProperty("excpClearDate")] public DateTime? ExcpClearDate { get; set; }

        [JsonIgnore] public bool HasGroupAOffense { get; set; }
        
        public Admin()
        {
            SegmentDescriptor = "10";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 84));
        }

        public void FixPaddings()
        {
            Location = Location.PadR(12);
            StationID = StationID.PadR(6);
            ClearedExceptionally = ClearedExceptionally.PadR(1);
        }
    }
}