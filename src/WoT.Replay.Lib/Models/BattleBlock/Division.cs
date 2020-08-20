using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class Division
    {
       [JsonProperty("bonusBattles")]
        public BonusBattles BonusBattles { get; set; }

        [JsonProperty("isLeague")]
        public bool IsLeague { get; set; }

        [JsonProperty("startRank")]
        public long StartRank { get; set; }
    }
}
