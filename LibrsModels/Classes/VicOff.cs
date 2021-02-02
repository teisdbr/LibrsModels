using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class VicOff : OldLibrsValues
        {
        
        [JsonProperty("victimSeqNum")]
        public string VictimSeqNum { get; set; }
        
        [JsonProperty("offenderNumberRelated")]
        public string OffenderNumberRelated { get; set; }
        
        [JsonProperty("victimOffenderRelation")]
        public string VictimOffenderRelation { get; set; }
    }
}