using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class Arrestee: LegacyLibrsValues, IPaddingFixer
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

        public void FixPaddings()
        {
            ArrestSeqNum = ArrestSeqNum.PadL(3, '0');;
            ArrestNumber = ArrestNumber.PadL(12);
            ArrTransactionNumber = ArrTransactionNumber.PadL(15);
            ArresteeName = ArresteeName.PadL(20);
            //TODO: Change arrest date to datetime type and extract string in librs format 
            ArrestDate = ArrestDate.PadL(8);
            ArrestType = ArrestType.PadL(1);
            MultipleArresteeIndicator = MultipleArresteeIndicator.PadL(1);
            Age = Age.PadL(3);
            //TODO: Change dob to datetime type and extract string in librs format 
            DOB = DOB.PadL(8);
            Sex = Sex.PadL(1);
            Race = Race.PadL(1);
            Ethnicity = Ethnicity.PadL(1);
            ResidentStatus = ResidentStatus.PadL(1);
            DispositionUnder17 = DispositionUnder17.PadL(1);
            ClearanceIndicator = ClearanceIndicator.PadL(1);
        }
    }
}