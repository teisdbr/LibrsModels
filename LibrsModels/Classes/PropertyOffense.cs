using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class PropertyOffense : OldLibrsValues
    {

        [JsonProperty("propertySequenceNumber")]
        public string PropertySequenceNumber { get; set; } = "   ";

        [JsonProperty("offenseSequenceNumber")]
        public string OffenseSequenceNumber { get; set; } = "   ";

        [JsonIgnore]
        public List<AssociatedProperty> AssociatedProperties { get; set; }

        [JsonIgnore]
        public List<AssociatedOffenses> AssociatedOffenses { get; set; }

        [JsonProperty("isDuplicate")] public bool IsDuplicate { get; set; } = false;
        
        public PropertyOffense()
        {
            SegmentDescriptor = "33";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 20));
            Padding = string.Concat(Enumerable.Repeat(" ", 98));
        }
    }
}