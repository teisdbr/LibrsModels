using System.Linq;
using LibrsModels.Classes;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class ArrArm : LegacyLibrsValues
    {

        [JsonProperty("arrestSeqNum")] public string ArrestSeqNum { get; set; } = "   ";

        [JsonProperty("arrestArmedWith")] public string ArrestArmedWith { get; set; } = "   ";
        public ArrArm()
        {
            SegmentDescriptor = "61";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 52));
        }
    }
}
