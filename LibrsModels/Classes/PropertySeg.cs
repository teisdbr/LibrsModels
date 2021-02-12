using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class PropertySeg: LegacyLibrsValues
    {

        [JsonProperty("numOfStolenVehicles")] public string NumOfStolenVehicles { get; set; } = "  ";

        [JsonProperty("numOfRecoveredVehicles")]
        public string NumOfRecoveredVehicles { get; set; } = "  ";
        
        public PropertySeg()
        {
            SegmentDescriptor = "30";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 100));
        }
    }
}