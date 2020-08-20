using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class XvmGlobal
    {
        [JsonProperty("minimap_circles")]
        public XvmMinimapCircles MinimapCircles { get; set; }
    }
}
