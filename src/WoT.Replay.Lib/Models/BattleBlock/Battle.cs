using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class Battle
    {
        [JsonProperty("clientVersionFromXml")]
        public string ClientVersionFromXml { get; set; }

        [JsonProperty("mapDisplayName")]
        public string MapDisplayName { get; set; }

        [JsonProperty("clientVersionFromExe")]
        public string ClientVersionFromExe { get; set; }

        [JsonProperty("gameplayID")]
        public string GameplayId { get; set; }

        [JsonProperty("playerID")]
        public ulong PlayerId { get; set; }

        [JsonProperty("serverName")]
        public string ServerName { get; set; }

        [JsonProperty("vehicles")]
        public Dictionary<string, Vehicle> Vehicles { get; set; }

        [JsonProperty("serverSettings")]
        public ServerSettings ServerSettings { get; set; }

        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        [JsonProperty("mapName")]
        public string MapName { get; set; }

        [JsonProperty("regionCode")]
        public string RegionCode { get; set; }

        [JsonProperty("battleType")]
        public long BattleType { get; set; }

        [JsonProperty("hasMods")]
        public bool HasMods { get; set; }

        [JsonProperty("playerVehicle")]
        public string PlayerVehicle { get; set; }

        [JsonProperty("xvm")]
        public Xvm Xvm { get; set; }

        [JsonProperty("playerName")]
        public string PlayerName { get; set; }
    }
}
