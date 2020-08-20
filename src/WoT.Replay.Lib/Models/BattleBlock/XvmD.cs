using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class XvmD
    {
        [JsonProperty("data")]
        public XvmDData Data { get; set; }

        [JsonProperty("accountDBID")]
        public long AccountDbid { get; set; }
    }
}
