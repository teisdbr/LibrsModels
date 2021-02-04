using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class PropertySeg: OldLibrsValues
    {

        [JsonProperty("numOfStolenVehicles")] public string NumOfStolenVehicles { get; set; } = "  ";

        [JsonProperty("numOfRecoveredVehicles")]
        public string NumOfRecoveredVehicles { get; set; } = "  ";
    }
}