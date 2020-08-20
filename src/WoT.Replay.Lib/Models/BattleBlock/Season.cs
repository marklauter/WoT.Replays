using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wot.Replays.Models
{
    public partial class Season
    {
        [JsonProperty("startSeason")]
        public long StartSeason { get; set; }

        [JsonProperty("endSeason")]
        public long EndSeason { get; set; }

        [JsonProperty("cycles")]
        public Dictionary<string, Cycle> Cycles { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }
    }
}
