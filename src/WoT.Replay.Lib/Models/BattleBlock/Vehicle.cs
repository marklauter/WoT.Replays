using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wot.Replays.Models
{
    public partial class Vehicle
    {
        [JsonProperty("forbidInBattleInvitations")]
        public bool ForbidInBattleInvitations { get; set; }

        [JsonProperty("vehicleType")]
        public string VehicleType { get; set; }

        [JsonProperty("isAlive")]
        public long IsAlive { get; set; }

        [JsonProperty("personalMissionIDs")]
        public long[] PersonalMissionIDs { get; set; }

        [JsonProperty("avatarSessionID")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long AvatarSessionId { get; set; }

        [JsonProperty("personalMissionInfo")]
        public Dictionary<string, long[]> PersonalMissionInfo { get; set; }

        [JsonProperty("wtr")]
        public long Wtr { get; set; }

        [JsonProperty("fakeName")]
        public string FakeName { get; set; }

        [JsonProperty("maxHealth")]
        public long MaxHealth { get; set; }

        [JsonProperty("igrType")]
        public long IgrType { get; set; }

        [JsonProperty("clanAbbrev")]
        public string ClanAbbrev { get; set; }

        [JsonProperty("ranked")]
        public long[] Ranked { get; set; }

        [JsonProperty("badges")]
        public long[][] Badges { get; set; }

        [JsonProperty("team")]
        public long Team { get; set; }

        [JsonProperty("overriddenBadge")]
        public long OverriddenBadge { get; set; }

        [JsonProperty("events")]
        public Events Events { get; set; }

        [JsonProperty("isTeamKiller")]
        public long IsTeamKiller { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
