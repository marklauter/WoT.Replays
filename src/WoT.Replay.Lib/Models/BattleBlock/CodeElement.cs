namespace Wot.Replays.Models
{
    public partial struct CodeElement
    {
        public long? Integer;
        public string String;

        public static implicit operator CodeElement(long Integer) => new CodeElement { Integer = Integer };
        public static implicit operator CodeElement(string String) => new CodeElement { String = String };
    }
}
