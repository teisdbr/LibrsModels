using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class Admin : LegacyLibrsValues, IPaddingFixer
    {
        [JsonProperty("location")] public string Location { get; set; } = "            ";

        [JsonProperty("stationID")] public string StationID { get; set; } = "      ";

        [JsonProperty("incidentDate")] public string IncidentDate { get; set; } = "           ";

        [JsonProperty("clearedExceptionally")] public string ClearedExceptionally { get; set; } = "N";

        [JsonProperty("excpClearDate")] public string ExcpClearDate { get; set; } = "        ";

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
            //TODO: Change incident date to datetime type and extract string in librs format 
            IncidentDate = IncidentDate.PadR(11);
            ClearedExceptionally = ClearedExceptionally.PadR(1);
            //TODO: Change excp clear date to datetime type and extract string in librs format 
            ExcpClearDate = ExcpClearDate.PadR(8);
        }
    }
}