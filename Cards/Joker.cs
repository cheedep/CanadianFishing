using Cards.Interfaces;

namespace Cards
{
    public class Joker : Card, IJoker
    {
        public Joker(int number)
            : base(Rank.Joker, SuitType.Special, true)
        {
            JokerNumber = number;
        }
        public int JokerNumber { get; private set; }
    }
}
