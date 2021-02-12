using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class Arrestee: LegacyLibrsValues
    {

        [JsonProperty("arrestSeqNum")] public string ArrestSeqNum { get; set; } = "   ";

        [JsonProperty("arrestNumber")] public string ArrestNumber { get; set; } = "            ";

        [JsonProperty("arrTransactionNumber")] public string ArrTransactionNumber { get; set; } = "               ";

        [JsonProperty("arresteeName")] public string ArresteeName { get; set; } = "                    ";

        [JsonProperty("arrestDate")] public string ArrestDate { get; set; } = "        ";

        [JsonProperty("arrestType")] public string ArrestType { get; set; } = " ";

        [JsonProperty("multipleArresteeIndicator")]
        public string MultipleArresteeIndicator { get; set; } = "N";

        [JsonProperty("age")] public string Age { get; set; } = "   ";

        [JsonProperty("dob")] public string DOB { get; set; } = "        ";

        [JsonProperty("sex")] public string Sex { get; set; } = " ";

        [JsonProperty("race")] public string Race { get; set; } = " ";

        [JsonProperty("ethnicity")] public string Ethnicity { get; set; } = " ";

        [JsonProperty("residentStatus")] public string ResidentStatus { get; set; } = " ";

        [JsonProperty("dispositionUnder17")] public string DispositionUnder17 { get; set; } = " ";

        [JsonProperty("clearanceIndicator")] public string ClearanceIndicator { get; set; } = " ";

        public Arrestee()
        {
            SegmentDescriptor = "60";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 17));
            Padding = string.Concat(Enumerable.Repeat(" ", 30));
        }
    }
}