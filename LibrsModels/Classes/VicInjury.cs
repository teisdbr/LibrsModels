using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class VicInjury: OldLibrsValues
    {
        
        [JsonProperty("victimSeqNum")]
        public string VictimSeqNum { get; set; }
        
        [JsonProperty("injuryType")]
        public string InjuryType { get; set; }
    }
}