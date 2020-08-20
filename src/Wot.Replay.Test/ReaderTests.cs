using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Text;
using Wot.Replays.Models;
using Wot.Replays.Converters;

namespace Wot.Replays
{
    [TestClass]
    public class ReaderTests
    {
        [TestMethod]
        public void Read_Pubbie_Block_Counts_Match()
        {
            var reader = new ReplayReader(@"Data\20200810_2101_france-F16_AMX_13_75_44_north_america.wotreplay");
            Assert.AreEqual(reader.BlockCount, reader.Blocks.Length);
        }

        [TestMethod]
        public void Read_Pubbie_BattleBlock_Parses()
        {
            var reader = new ReplayReader(@"Data\20200810_2101_france-F16_AMX_13_75_44_north_america.wotreplay");
            Assert.AreEqual(reader.BlockCount, reader.Blocks.Length);
            var playerBlockJson = Encoding.UTF8.GetString(reader.Blocks[0]);
            var battle = JsonConvert.DeserializeObject<Battle>(playerBlockJson, ConverterSettings.Settings);
        }
    }
}
