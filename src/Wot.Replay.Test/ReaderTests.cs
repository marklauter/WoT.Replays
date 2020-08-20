using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Text;
using Wot.Replays.Converters;
using Wot.Replays.Models;

namespace Wot.Replays
{
    [TestClass]
    public class ReaderTests
    {
        [TestMethod]
        public void Read_Pubbie_Block_Counts_Match()
        {
            var replay = ReplayReader.Read(@"Data\20200810_2101_france-F16_AMX_13_75_44_north_america.wotreplay");
            Assert.AreEqual(replay.BlockCount, replay.Blocks.Length);
        }

        [TestMethod]
        public void Read_Pubbie_BattleBlock_Parses()
        {
            var replay = ReplayReader.Read(@"Data\20200810_2101_france-F16_AMX_13_75_44_north_america.wotreplay");
            Assert.AreEqual(replay.BlockCount, replay.Blocks.Length);
            var playerBlockJson = Encoding.UTF8.GetString(replay.Blocks[0]);
            var battle = JsonConvert.DeserializeObject<Battle>(playerBlockJson, ConverterSettings.Settings);
            Assert.IsTrue(String.Compare(battle.PlayerName, "7th_Cav_Trooper", StringComparison.InvariantCultureIgnoreCase) == 0);
        }
    }
}
