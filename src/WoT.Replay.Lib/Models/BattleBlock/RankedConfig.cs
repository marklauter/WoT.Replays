using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wot.Replays.Models
{
    public partial class RankedConfig
    {
        [JsonProperty("unburnableStepRanks")]
        public object[] UnburnableStepRanks { get; set; }

        [JsonProperty("expireSeasons")]
        public long ExpireSeasons { get; set; }

        [JsonProperty("numPlayers")]
        public long NumPlayers { get; set; }

        [JsonProperty("yearLBSize")]
        public long YearLbSize { get; set; }

        [JsonProperty("unburnableRanks")]
        public long[] UnburnableRanks { get; set; }

        [JsonProperty("efficiencyGroups")]
        public Dictionary<string, double[]> EfficiencyGroups { get; set; }

        [JsonProperty("mmFailTimes")]
        public long[] MmFailTimes { get; set; }

        [JsonProperty("expectedSeasons")]
        public long ExpectedSeasons { get; set; }

        [JsonProperty("primeTimes")]
        public Dictionary<string, PrimeTime> PrimeTimes { get; set; }

        [JsonProperty("rankGroups")]
        public long[] RankGroups { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("bonusBattlesMultiplier")]
        public long BonusBattlesMultiplier { get; set; }

        [JsonProperty("isShopEnabled")]
        public bool IsShopEnabled { get; set; }

        [JsonProperty("forbiddenClassTags")]
        public object[] ForbiddenClassTags { get; set; }

        [JsonProperty("shields")]
        public Dictionary<string, long[]> Shields { get; set; }

        [JsonProperty("cycleTimes")]
        public object[] CycleTimes { get; set; }

        [JsonProperty("arenaTime")]
        public long ArenaTime { get; set; }

        [JsonProperty("minXP")]
        public long MinXp { get; set; }

        [JsonProperty("minLevel")]
        public long MinLevel { get; set; }

        [JsonProperty("winnerRankChanges")]
        public long[] WinnerRankChanges { get; set; }

        [JsonProperty("qualificationBonusBattles")]
        public LeaguesBonusBattleElement[] QualificationBonusBattles { get; set; }

        [JsonProperty("seasons")]
        public Dictionary<string, Season> Seasons { get; set; }

        [JsonProperty("loserRankChanges")]
        public long[] LoserRankChanges { get; set; }

        [JsonProperty("cycleFinishSeconds")]
        public long CycleFinishSeconds { get; set; }

        [JsonProperty("divisions")]
        public Dictionary<string, Division> Divisions { get; set; }

        [JsonProperty("isYearLBEnabled")]
        public bool IsYearLbEnabled { get; set; }

        [JsonProperty("qualificationBattles")]
        public long QualificationBattles { get; set; }

        [JsonProperty("peripheryIDs")]
        public long[] PeripheryIDs { get; set; }

        [JsonProperty("accRanks")]
        public long AccRanks { get; set; }

        [JsonProperty("maxLevel")]
        public long MaxLevel { get; set; }

        [JsonProperty("accSteps")]
        public long[] AccSteps { get; set; }

        [JsonProperty("leaguesBonusBattles")]
        public LeaguesBonusBattleElement[] LeaguesBonusBattles { get; set; }

        [JsonProperty("yearAwardsMarks")]
        public long[] YearAwardsMarks { get; set; }

        [JsonProperty("forbiddenVehTypes")]
        public long[] ForbiddenVehTypes { get; set; }
    }
}
