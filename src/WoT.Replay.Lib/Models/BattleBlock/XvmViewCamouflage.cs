using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class XvmViewCamouflage
    {
        [JsonProperty("skill")]
        public long Skill { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
