using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class LeaguesBonusBattleElement
    {
        [JsonProperty("battlesCount")]
        public long BattlesCount { get; set; }

        [JsonProperty("steps")]
        public long Steps { get; set; }
    }
}
