using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class XvmTiming
    {
        [JsonProperty("p")]
        public long P { get; set; }

        [JsonProperty("m")]
        public M M { get; set; }

        [JsonProperty("t")]
        public double T { get; set; }

        [JsonProperty("d")]
        public XvmD D { get; set; }
    }
}
