namespace Wot.Replays.Models
{
    public partial struct BonusBattles
    {
        public BonusBattle[] BonusBattleArray;
        public Events Events;

        public static implicit operator BonusBattles(BonusBattle[] BonusBattleArray)
        {
            return new BonusBattles { BonusBattleArray = BonusBattleArray };
        }

        public static implicit operator BonusBattles(Events Events)
        {
            return new BonusBattles { Events = Events };
        }
    }
}
