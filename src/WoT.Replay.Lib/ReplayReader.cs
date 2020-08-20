using System;
using System.IO;
using WoT.Replays;

namespace Wot.Replays
{
    public static class ReplayReader
    {
        private const int MagicNumber = 288633362;

        public static Replay Read(string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            using var file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using var reader = new BinaryReader(file);
            
            var magicNumber = reader.ReadInt32();
            if(MagicNumber != magicNumber)
            {
                throw new InvalidDataException($"file is not a wot replay. expected magic number: {MagicNumber}, actual: {magicNumber}");
            }

            var blockCount = reader.ReadInt32();
            var blocks = new byte[blockCount][];
            
            for (var i = 0; i < blockCount; ++i)
            {
                var blockSize = reader.ReadInt32();
                blocks[i] = reader.ReadBytes(blockSize);
            }

            return new Replay(blockCount, blocks);
        }
    }
}
