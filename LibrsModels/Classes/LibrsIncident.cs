using Newtonsoft.Json;
using System.Collections.Generic;

namespace LibrsModels.Classes
{
    public class LibrsIncident
    {
        [JsonIgnore]
        [JsonProperty("hasErrors")]
        public bool HasErrors { get; set; }

        [JsonIgnore]
        [JsonProperty("errors")]
        public List<object> Errors { get; set; }

        [JsonIgnore]
        [JsonProperty("warnings")]
        public List<object> Warnings { get; set; }

        [JsonProperty("admin")]
        public Admin Admin { get; set; }
        
        [JsonProperty("adminMod")]
        public AdminMod AdminMod { get; set; }
        
        [JsonProperty("offense")]
        public List<Offense> Offense { get; set; }
        
        [JsonProperty("propertySeg")]
        public PropertySeg PropertySeg { get; set; }
        
        [JsonProperty("propDesc")]
        public List<PropDesc> PropDesc { get; set; }
        
        [JsonProperty("propMod")]
        public PropMod PropMod { get; set; }
        
        [JsonProperty("propertyOffense")]
        public List<PropertyOffense> PropertyOffense { get; set; }
        
        [JsonProperty("offender")]
        public List<Offender> Offender { get; set; }
        
        [JsonProperty("offUsing")]
        public List<OffUsing> OffUsing { get; set; }
        
        [JsonProperty("victim")]
        public List<Victim> Victim { get; set; }
        
        [JsonProperty("vicInjury")]
        public List<VicInjury> VicInjury { get; set; }
        
        [JsonProperty("vicOff")]
        public List<VicOff> VicOff { get; set; }
        
        [JsonProperty("arrestee")]
        public List<Arrestee> Arrestee { get; set; }
        
        [JsonProperty("arrArm")]
        public List<ArrArm> ArrArm { get; set; }
        
        [JsonProperty("arrStatute")]
        public List<ArrStatute> ArrStatute { get; set; }
        
        [JsonProperty("arrMod")]
        public ArrMod ArrMod { get; set; }
        
        [JsonProperty("inchoate")]
        public bool Inchoate { get; set; }
        
        [JsonProperty("propertyLossTypeFlags")]
        public object PropertyLossTypeFlags { get; set; }

        [JsonIgnore]
        public bool InsertedtoDB { get; set; }

        [JsonIgnore]
        public bool DidCachePropertyLossTypes { get; set; }

        [JsonIgnore]
        public string EntireLineSegments { get; set; }
    }
}