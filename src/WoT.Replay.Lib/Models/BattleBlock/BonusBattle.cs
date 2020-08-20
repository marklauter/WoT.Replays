using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class BonusBattle
    {
        [JsonProperty("efficiency")]
        public double Efficiency { get; set; }

        [JsonProperty("battlesCount")]
        public long BattlesCount { get; set; }
    }
}
