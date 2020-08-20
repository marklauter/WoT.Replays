using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class ServerSettings
    {
        [JsonProperty("isNoAllyDamage")]
        public long[] IsNoAllyDamage { get; set; }

        [JsonProperty("spgRedesignFeatures")]
        public SpgRedesignFeatures SpgRedesignFeatures { get; set; }

        [JsonProperty("isPotapovQuestEnabled")]
        public bool IsPotapovQuestEnabled { get; set; }

        [JsonProperty("roaming")]
        public ServerSettingsRoaming[] Roaming { get; set; }

        [JsonProperty("ranked_config")]
        public RankedConfig RankedConfig { get; set; }
    }
}
