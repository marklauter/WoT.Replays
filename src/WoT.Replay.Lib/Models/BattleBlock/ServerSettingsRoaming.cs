namespace Wot.Replays.Models
{
    public partial struct ServerSettingsRoaming
    {
        public CodeElement[][] AnythingArrayArray;
        public long? Integer;

        public static implicit operator ServerSettingsRoaming(CodeElement[][] AnythingArrayArray)
        {
            return new ServerSettingsRoaming { AnythingArrayArray = AnythingArrayArray };
        }

        public static implicit operator ServerSettingsRoaming(long Integer)
        {
            return new ServerSettingsRoaming { Integer = Integer };
        }
    }
}
