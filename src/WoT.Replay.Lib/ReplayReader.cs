using System;
using System.IO;

namespace Wot.Replays
{
    public class ReplayReader
    {
        public ReplayReader(string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            this.Read(fileName);
        }

        public int BlockCount { get; private set; }

        public byte[][] Blocks { get; private set; }

        private void Read(string fileName)
        {
            using var file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            using var reader = new BinaryReader(file);
            _ = reader.ReadInt32(); // read past the magic number
            this.BlockCount = reader.ReadInt32();
            this.Blocks = new byte[this.BlockCount][];
            for (var i = 0; i < this.BlockCount; ++i)
            {
                var blockSize = reader.ReadInt32();
                this.Blocks[i] = reader.ReadBytes(blockSize);
            }
        }
    }
}
