using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace Wot.Replays
{
    [TestClass]
    public class ReaderTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var reader = new ReplayReader(@"Data\20200707_1946_japan-J16_ST_B1_06_ensk.wotreplay");
            var reader = new ReplayReader(@"Data\20200810_2101_france-F16_AMX_13_75_44_north_america.wotreplay");
            var playerBlockJson = Encoding.UTF8.GetString(reader.Blocks[0]);
            var eventBlockJson = Encoding.UTF8.GetString(reader.Blocks[1]);
            Assert.AreEqual(reader.BlockCount, reader.Blocks.Length);
        }
    }
}
