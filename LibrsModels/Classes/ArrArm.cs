using LibrsModels.Classes;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class ArrArm : OldLibrsValues
    {

        [JsonProperty("arrestSeqNum")] public string ArrestSeqNum { get; set; } = "   ";

        [JsonProperty("arrestArmedWith")] public string ArrestArmedWith { get; set; } = "   ";
        public void OldVals()
        {
            SegmentDescriptor = "61";
            ExpansionBuffer = "                    ";
            Padding = "                                                    ";
        }
    }
}
