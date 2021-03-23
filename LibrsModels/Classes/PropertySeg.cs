using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class PropertySeg: LegacyLibrsValues, IPaddingFixer
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

        public void FixPaddings()
        {
            NumOfStolenVehicles = NumOfStolenVehicles.PadL(2);
            NumOfRecoveredVehicles = NumOfStolenVehicles.PadL(2);
        }
    }
}