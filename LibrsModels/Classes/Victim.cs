using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using TeUtil.Extensions;

namespace LibrsModels.Classes
{
    public class Victim: LegacyLibrsValues, IPaddingFixer
    {
        [JsonIgnore]
        public int GetAllPossibleAggravatedFlags { get; set; }
        
        [JsonIgnore]
        public int GetAll09aAggravatedFlags { get; set; }
        
        [JsonIgnore]
        public int GetAll09bAggravatedFlags { get; set; }
        
        [JsonIgnore]
        public int GetAll09cAggravatedFlags { get; set; }
        
        [JsonIgnore]
        public int GetProvidedAggravatedFlags { get; set; }
        
        [JsonIgnore]
        public bool AreAllDataElement31ProvidedChoicesValid { get; set; }
        
        [JsonIgnore]
        public List<object> GetInvalidDataElement31Choices { get; set; }

        [JsonProperty("officerActivity")] public int? OfficerActivity { get; set; }

        [JsonProperty("victimSeqNum")] public string VictimSeqNum { get; set; } = "   ";

        [JsonProperty("victimType")] public string VictimType { get; set; } = " ";

        [JsonProperty("age")] public string Age { get; set; } = "   ";

        [JsonProperty("dob")] public string DOB { get; set; } = "        ";

        [JsonProperty("sex")] public string Sex { get; set; } = " ";

        [JsonProperty("race")] public string Race { get; set; } = " ";

        [JsonProperty("ethnicity")] public string Ethnicity { get; set; } = " ";

        [JsonProperty("residentStatus")] public string ResidentStatus { get; set; } = " ";

        [JsonProperty("aggravatedAssault1")] public string AggravatedAssault1 { get; set; } = "  ";

        [JsonProperty("aggravatedAssault2")] public string AggravatedAssault2 { get; set; } = "  ";

        [JsonProperty("aggravatedAssault3")] public string AggravatedAssault3 { get; set; } = "  ";

        [JsonProperty("additionalHomicide")] public string AdditionalHomicide { get; set; } = " ";

        [JsonProperty("officerActivityCircumstance")]
        public string OfficerActivityCircumstance { get; set; } = "  ";

        [JsonProperty("officerAssignmentType")]
        public string OfficerAssignmentType { get; set; } = " ";

        [JsonProperty("officerOri")] public string OfficerOri { get; set; } = "         ";
        
        public Victim()
        {
            SegmentDescriptor = "52";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 6));
            Padding = string.Concat(Enumerable.Repeat(" ", 81));
        }

        public void FixPaddings()
        {
            VictimSeqNum = VictimSeqNum.PadL(3, '0');;
            VictimType = VictimType.PadR(1);
            Age = PadVictimAge(Age);
            Ethnicity = Ethnicity.PadR(1);
            ResidentStatus = ResidentStatus.PadR(1);
            AggravatedAssault1 = AggravatedAssault1.PadL(2,'0');
            AggravatedAssault2 = AggravatedAssault2.PadL(2,'0');
            AggravatedAssault3 = AggravatedAssault3.PadL(2,'0');
            AdditionalHomicide = AdditionalHomicide.PadR(1);
            OfficerActivityCircumstance = OfficerActivityCircumstance.PadL(2, '0');
            OfficerAssignmentType = OfficerAssignmentType.PadR(1);
            OfficerOri = OfficerOri.PadL(9);
        }

        private string PadVictimAge(string age)
        {
            // If estimated, pad 3 characters
            if (age.Contains('E'))
            {
                return age.PadL(3, '0');
            } 
            else if (int.TryParse(age, out var parsedAge))
            {
                return parsedAge.ToString().PadL(2, '0') + ' ';
            }

            // If all else fails, pad to 3 spaces. This helps against 'NB ' for instance.
            return age.PadR(3);
        }
    }
}