namespace Wot.Replays.Models
{
    public partial struct ServerSettingsRoaming
    {
        public CodeElement[][] AnythingArrayArray;
        public long? Integer;

        public static implicit operator ServerSettingsRoaming(CodeElement[][] AnythingArrayArray) => new ServerSettingsRoaming { AnythingArrayArray = AnythingArrayArray };
        public static implicit operator ServerSettingsRoaming(long Integer) => new ServerSettingsRoaming { Integer = Integer };
    }
}
