using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace LibrsModels.Classes
{
    public class PropDesc : OldLibrsValues
    {

        [JsonProperty("propertySeqNum")] public string PropertySeqNum { get; set; } = "   ";

        [JsonProperty("propertyLossType")] public string PropertyLossType { get; set; } = " ";

        [JsonProperty("propertyDescription")] public string PropertyDescription { get; set; } = "  ";

        [JsonProperty("propertyValue")] public string PropertyValue { get; set; } = "         ";

        [JsonProperty("dateRecovered")] public string DateRecovered { get; set; } = "        ";

        [JsonProperty("suspectedDrugType")] public string SuspectedDrugType { get; set; } = "  ";

        [JsonProperty("estimatedDrugQty")] public string EstimatedDrugQty { get; set; } = "             ";

        [JsonProperty("typeDrugMeas")] public string TypeDrugMeas { get; set; } = "  ";
        
        [JsonIgnore]
        public object ty_num { get; set; }
        
        [JsonIgnore]
        public object la_rs { get; set; }
        
        [JsonIgnore]
        public object nibr { get; set; }
        
        [JsonIgnore]
        public int n_val_prop { get; set; }

        [JsonIgnore]
        public List<RelationshipsToOffenses> RelationshipsToOffenses { get; set; }

        [JsonIgnore]
        public List<RelatedOffenses> RelatedOffenses { get; set; }
        
        public PropDesc()
        {
            SegmentDescriptor = "31";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 17));
            Padding = string.Concat(Enumerable.Repeat(" ", 67));
        }
    }
}