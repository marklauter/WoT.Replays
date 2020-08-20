using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class PrimeTime
    {
        [JsonProperty("start")]
        public long[] Start { get; set; }

        [JsonProperty("end")]
        public long[] End { get; set; }

        [JsonProperty("weekdays")]
        public long[] Weekdays { get; set; }

        [JsonProperty("peripheryIDs")]
        public long[] PeripheryIDs { get; set; }
    }
}
