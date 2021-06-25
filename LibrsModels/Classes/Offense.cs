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

        [JsonProperty("criminalActivity")] public List<string> CriminalActivity { get; set; }
        
        [JsonProperty("weapons")] public List<Weapon> Weapons { get; set; }
        
        [JsonProperty("cargoTheft")] public string CargoTheft { get; set; } = " ";

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
            // If seqNum is not provided set it to "   "
            OffenseSeqNum = OffenseSeqNum.PadL(3, '0');
            LrsNumber = LrsNumber.PadR(12);
            AttemptedCompleted = AttemptedCompleted.PadR(1).ToUpper();
            // If seqNum is not provided set it to "   "
            OffConnecttoVic = OffConnecttoVic.PadL(3, '0');
            LocationType = LocationType.PadR(2);
            Premises = Premises.PadR(2);
            MethodOfEntry = MethodOfEntry.PadR(1);
            //CriminalActivity[0] = CriminalActivity[0].PadR(1) ?? "   ";
            //CriminalActivity[1] = CriminalActivity[1].PadR(1) ?? "   ";
            //CriminalActivity[2] = CriminalActivity[2].PadR(1) ?? "   ";
            Weapons[0].WeaponForce = Weapons[0].WeaponForce.PadR(3) ?? "   ";
            Weapons[1].WeaponForce = Weapons[1].WeaponForce.PadR(3) ?? "   ";
            Weapons[2].WeaponForce = Weapons[2].WeaponForce.PadR(3) ?? "   ";
            CargoTheft = CargoTheft.PadR(1);
            // Weapons[0].StolenFirearm = Weapons[0].StolenFirearm.PadR(1);
            // Weapons[1].StolenFirearm = Weapons[1].StolenFirearm.PadR(1);
            // Weapons[2].StolenFirearm = Weapons[2].StolenFirearm.PadR(1);
            // Weapons[0].DischargedFirearm = Weapons[0].DischargedFirearm.PadR(1);
            // Weapons[1].DischargedFirearm = Weapons[1].DischargedFirearm.PadR(1);
            // Weapons[2].DischargedFirearm = Weapons[2].DischargedFirearm.PadR(1);
            AgencyAssignedNibrs = AgencyAssignedNibrs.PadR(3);
            Inchoate = Inchoate.PadR(2);
        }
    }

    public class Weapon
    {
        [JsonProperty("weaponForce")] public string WeaponForce { get; set; } = "   ";

        [JsonProperty("stolenFirearm")] public bool? StolenFirearm { get; set; }

        [JsonProperty("dischargedFirearm")] public bool? DischargedFirearm { get; set; }

    }
}