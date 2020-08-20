using System;

namespace WoT.Replays
{
    public class Replay
    {
        public Replay(int blockCount, byte[][] blocks)
        {
            if (blockCount < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(blockCount), $"value of {nameof(blockCount)} must be > 0");
            }

            if (blocks == null)
            {
                throw new ArgumentNullException(nameof(blocks));
            }

            if (blocks.Length != blockCount)
            {
                throw new ArgumentException($"{nameof(blockCount)} and {nameof(blocks)}.Length must match");
            }

            this.BlockCount = blockCount;
            this.Blocks = blocks;
        }

        public int BlockCount { get; }

        public byte[][] Blocks { get; }
    }
}
