using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class ArrMod : OldLibrsValues
    {
        [JsonProperty("lrsNumber")]
        public string LRSNumber {get;set;}
    }
}