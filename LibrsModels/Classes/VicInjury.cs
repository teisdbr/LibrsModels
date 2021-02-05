using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class VicInjury: OldLibrsValues
    {

        [JsonProperty("victimSeqNum")] public string VictimSeqNum { get; set; } = "   ";

        [JsonProperty("injuryType")] public string InjuryType { get; set; } = " ";
        
        public VicInjury()
        {
            SegmentDescriptor = "51";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 100));
        }
    }
}