using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class VicOff : OldLibrsValues
    {

        [JsonProperty("victimSeqNum")] public string VictimSeqNum { get; set; } = "   ";

        [JsonProperty("offenderNumberRelated")]
        public string OffenderNumberRelated { get; set; } = "   ";

        [JsonProperty("victimOffenderRelation")]
        public string VictimOffenderRelation { get; set; } = "  ";
        
        public VicOff()
        {
            SegmentDescriptor = "52";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 100));
        }
    }
}