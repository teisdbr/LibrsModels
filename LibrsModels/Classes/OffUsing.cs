using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class OffUsing : OldLibrsValues
    {
        
        [JsonProperty("offenderSeqNum")]
        public string OffenderSeqNum { get; set; }
        
        [JsonProperty("offUsingGamingMot")]
        public string OffUsingGamingMot { get; set; }
    }
}