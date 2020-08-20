using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class XvmCapabilities
    {
        [JsonProperty("sixthSense")]
        public bool SixthSense { get; set; }
    }
}
