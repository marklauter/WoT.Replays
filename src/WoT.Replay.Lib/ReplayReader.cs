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
            if (MagicNumber != magicNumber)
            {
                throw new InvalidDataException($"file is not a wot replay. expected magic number: {MagicNumber}, actual: {magicNumber}");
            }

            // todo: the block count might actually be bit encoded
            // see https://github.com/raszpl/wotdecoder/blob/master/wotdecoder.py
            // # filename= name of .wotreplay file
            // # to_decode= bitmask of chunks you want decoded.
            // # We do not just count blocks as they are in replay files. Instead we always decode
            // # Bit 0 = first Json block, starting player list
            // # Bit 1 = second Json block, simplified frag count
            // # Bit 2 = pickle, proper battle result with damage numbers
            // # 7(binary 111) means decode all three. 5(binary 101) means decode first Json and pikle.
            // #
            // # returns decoded_chunks[0:3], chunks bitmask, decoder status
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
