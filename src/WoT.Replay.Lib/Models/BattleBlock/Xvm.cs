using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class Xvm
    {
        [JsonProperty("timing")]
        public XvmTiming[] Timing { get; set; }

        [JsonProperty("global")]
        public XvmGlobal Global { get; set; }

        [JsonProperty("ver")]
        public string Ver { get; set; }
    }
}
