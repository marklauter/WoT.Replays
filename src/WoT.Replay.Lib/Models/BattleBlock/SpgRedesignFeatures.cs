using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class SpgRedesignFeatures
    {
        [JsonProperty("stunEnabled")]
        public bool StunEnabled { get; set; }

        [JsonProperty("markTargetAreaEnabled")]
        public bool MarkTargetAreaEnabled { get; set; }
    }
}
