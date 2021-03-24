using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class OffUsing : LegacyLibrsValues, IPaddingFixer
    {

        [JsonProperty("offenderSeqNum")] public string OffenderSeqNum { get; set; } = "   ";

        [JsonProperty("offUsingGamingMot")] public string OffUsingGamingMot { get; set; } = "     ";
        
        public OffUsing()
        {
            SegmentDescriptor = "41";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 100));
        }

        public void FixPaddings()
        {
            OffenderSeqNum = OffenderSeqNum.PadL(3);
            OffUsingGamingMot = OffUsingGamingMot.PadL(4);
        }
    }
}