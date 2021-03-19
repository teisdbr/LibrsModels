using Newtonsoft.Json;
using System.Collections.Generic;

namespace LibrsModels.Classes
{
    public interface ILibrsIncident
    {
        Admin Admin { get; }
        List<Offense> Offense { get; }
        PropertySeg PropertySeg { get; }
        List<PropDesc> PropDesc { get; }
        List<PropertyOffense> PropertyOffense { get; }
        List<Offender> Offender { get; }
        List<OffUsing> OffUsing { get; }
        List<Victim> Victim { get; }
        List<VicInjury> VicInjury { get; }
        List<VicOff> VicOff { get; }
        List<Arrestee> Arrestees { get; }
        List<ArrArm> ArrArm { get; }
        List<ArrStatute> ArrStatute { get; }
        string ActionType { get; }
        string IncidentNumber { get; }
    }

    public class LibrsIncident : ILibrsIncident
    {
        [JsonProperty("hasErrors")]
        public bool HasErrors { get; set; }
        
        [JsonProperty("errors")]
        public List<Errors> Errors { get; set; }
        
        [JsonProperty("warnings")]
        public List<Warnings> Warnings { get; set; }

        [JsonProperty("admin")] public Admin Admin { get; set; }

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
        public List<Arrestee> Arrestees { get; set; }

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
        
        [JsonProperty("actionType")]
        public string ActionType { get; set; }
        
        [JsonProperty("incidentNumber")]
        public string IncidentNumber { get; set; }

        [JsonIgnore]
        public bool InsertedtoDB { get; set; }

        [JsonIgnore]
        public bool DidCachePropertyLossTypes { get; set; }

        [JsonIgnore]
        public string EntireLineSegments { get; set; }

    }
}