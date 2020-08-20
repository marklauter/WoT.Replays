using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class XvmMinimapCircles
    {
        [JsonProperty("base_gun_reload_time")]
        public long BaseGunReloadTime { get; set; }

        [JsonProperty("view_rammer")]
        public bool ViewRammer { get; set; }

        [JsonProperty("base_loaders_skill")]
        public long BaseLoadersSkill { get; set; }

        [JsonProperty("base_radio_distance")]
        public long BaseRadioDistance { get; set; }

        [JsonProperty("view_commander_eagleEye")]
        public long ViewCommanderEagleEye { get; set; }

        [JsonProperty("view_radioman_finder")]
        public long ViewRadiomanFinder { get; set; }

        [JsonProperty("base_radioman_skill")]
        public long BaseRadiomanSkill { get; set; }

        [JsonProperty("view_stereoscope")]
        public bool ViewStereoscope { get; set; }

        [JsonProperty("view_ventilation")]
        public bool ViewVentilation { get; set; }

        [JsonProperty("view_consumable")]
        public bool ViewConsumable { get; set; }

        [JsonProperty("view_radioman_inventor")]
        public long ViewRadiomanInventor { get; set; }

        [JsonProperty("view_camouflage")]
        public XvmViewCamouflage[] ViewCamouflage { get; set; }

        [JsonProperty("view_brothers_in_arms")]
        public bool ViewBrothersInArms { get; set; }

        [JsonProperty("commander_sixthSense")]
        public bool CommanderSixthSense { get; set; }

        [JsonProperty("view_coated_optics")]
        public bool ViewCoatedOptics { get; set; }

        [JsonProperty("is_full_crew")]
        public bool IsFullCrew { get; set; }

        [JsonProperty("view_distance_vehicle")]
        public long ViewDistanceVehicle { get; set; }

        [JsonProperty("artillery_range")]
        public long ArtilleryRange { get; set; }

        [JsonProperty("base_commander_skill")]
        public long BaseCommanderSkill { get; set; }

        [JsonProperty("vehCD")]
        public long VehCd { get; set; }

        [JsonProperty("shell_range")]
        public long ShellRange { get; set; }
    }
}
