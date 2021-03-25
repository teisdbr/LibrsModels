using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class Offender : LegacyLibrsValues, IPaddingFixer
    {

        [JsonProperty("offenderSeqNum")] public string OffenderSeqNum { get; set; } = "   ";

        [JsonProperty("age")] public string Age { get; set; } = "   ";

        [JsonProperty("dob")] public string Dob { get; set; } = "        ";

        [JsonProperty("sex")] public string Sex { get; set; } = " ";

        [JsonProperty("race")] public string Race { get; set; } = " ";

        [JsonProperty("biasMotivation")] public string BiasMotivation { get; set; } = "  ";

        [JsonProperty("ethnicity")] public string Ethnicity { get; set; } = " ";
        
        public Offender()
        {
            SegmentDescriptor = "40";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 19));
            Padding = string.Concat(Enumerable.Repeat(" ", 86));
        }

        public void FixPaddings()
        {
            OffenderSeqNum = OffenderSeqNum.PadL(3, '0');;
            Age = Age.PadL(3);
            //TODO: Change dob to datetime type and extract string in librs format 
            Dob = Dob.PadL(8);
            Sex = Sex.PadL(1);
            Race = Race.PadL(1);
            BiasMotivation = BiasMotivation.PadL(2);
            Ethnicity = Ethnicity.PadL(1);
        }
    }
}