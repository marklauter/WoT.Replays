using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class Cycle
    {
        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("end")]
        public long End { get; set; }
    }
}
