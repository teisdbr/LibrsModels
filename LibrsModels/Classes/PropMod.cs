using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace LibrsModels.Classes
{
    public class PropMod
    {
        [JsonProperty("lrsNumber")]
        public string LRSNumber { get; set; }
    }
}