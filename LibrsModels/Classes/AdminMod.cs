using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class AdminMod : OldLibrsValues
    {
        [JsonProperty("lrsNumber")]
        public string LRSNumber {get;set;}
    }
}