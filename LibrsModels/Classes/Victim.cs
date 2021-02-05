using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class Victim: OldLibrsValues
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
    }
}