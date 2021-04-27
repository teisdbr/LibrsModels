using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace LibrsModels.Classes
{
    public class Offense : LegacyLibrsValues, IPaddingFixer
    {
        [JsonProperty("offenseSeqNum")] public string OffenseSeqNum { get; set; } = "   ";

        [JsonProperty("attemptedCompleted")] public string AttemptedCompleted { get; set; } = " ";

        [JsonProperty("offConnecttoVic")] public string OffConnecttoVic { get; set; } = "   ";

        [JsonProperty("locationType")] public string LocationType { get; set; } = "  ";

        [JsonProperty("premises")] public string Premises { get; set; } = "  ";

        [JsonProperty("methodOfEntry")] public string MethodOfEntry { get; set; } = " ";

        [JsonProperty("criminalActivity1")] public string CriminalActivity1 { get; set; } = " ";

        [JsonProperty("criminalActivity2")] public string CriminalActivity2 { get; set; } = " ";

        [JsonProperty("criminalActivity3")] public string CriminalActivity3 { get; set; } = " ";

        [JsonProperty("weaponForce1")] public string WeaponForce1 { get; set; } = "   ";

        [JsonProperty("weaponForce2")] public string WeaponForce2 { get; set; } = "   ";

        [JsonProperty("weaponForce3")] public string WeaponForce3 { get; set; } = "   ";

        [JsonProperty("agencyAssignedNibrs")] public string AgencyAssignedNibrs { get; set; } = "   ";

        [JsonIgnore]
        public List<RelationshipsToProperty> RelationshipsToProperties { get; set; }

        [JsonIgnore]
        public List<RelatedProperty> RelatedProperties { get; set; }
        
        [JsonProperty("propertyLossTypeFlags")]
        public int? PropertyLossTypeFlags { get; set; }
        
        [JsonIgnore]
        public List<ValidateLars> ValidateLars { get; set; }

        [JsonIgnore]
        public List<FbiValidate> FbiValidates { get; set; }

        [JsonProperty("lrsNumber")] public string LrsNumber { get; set; } = "            ";

        [JsonIgnore] public bool OfficerDidAssignNibrs { get; set; } = true;

        [JsonProperty("inchoate")] public string Inchoate { get; set; } = " ";

        [JsonProperty("offenseGroup")] public string OffenseGroup { get; set; } = " ";
        
        public Offense()
        {
            SegmentDescriptor = "20";
            ExpansionBuffer = string.Concat(Enumerable.Repeat(" ", 16));
            Padding = string.Concat(Enumerable.Repeat(" ", 68));
        }

        public void FixPaddings()
        {
            OffenseSeqNum = OffenseSeqNum.PadL(3, '0');
            LrsNumber = LrsNumber.PadR(12);
            AttemptedCompleted = AttemptedCompleted.PadR(1).ToUpper();
            OffConnecttoVic = OffConnecttoVic.PadL(3, '0');
            LocationType = LocationType.PadR(2);
            Premises = Premises.PadR(2);
            MethodOfEntry = MethodOfEntry.PadR(1);
            CriminalActivity1 = CriminalActivity1.PadR(1);
            CriminalActivity2 = CriminalActivity2.PadR(1);
            CriminalActivity3 = CriminalActivity3.PadR(1);
            WeaponForce1 = WeaponForce1.PadR(3);
            WeaponForce2 = WeaponForce2.PadR(3);
            WeaponForce3 = WeaponForce3.PadR(3);
            AgencyAssignedNibrs = AgencyAssignedNibrs.PadR(3);
            Inchoate = Inchoate.PadR(2);
        }
    }
}