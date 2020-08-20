using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class XvmDData
    {
        [JsonProperty("event")]
        public Event Event { get; set; }

        [JsonProperty("capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public XvmCapabilities Capabilities { get; set; }

        [JsonProperty("totalTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalTime { get; set; }

        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public Level? Level { get; set; }

        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public CodeElement? Code { get; set; }

        [JsonProperty("zoneID", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneId { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public long? Color { get; set; }

        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public long[][] Path { get; set; }
    }
}
