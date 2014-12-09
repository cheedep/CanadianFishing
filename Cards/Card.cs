using System;
using Cards.Interfaces;

namespace Cards
{
    public class Card : ICard
    {
        public Card(Rank rank, SuitType suitType)
        {
            if(rank == Rank.Joker || suitType == SuitType.Special)
                throw new ArgumentException("Cannot accept Joker or Special Type");

            Rank = rank;
            SuitType = suitType;
        }

        protected Card(Rank rank, SuitType suitType, bool isSpecial)
        {
            Rank = rank;
            SuitType = suitType;
        }

        public Rank Rank { get; private set; }
        public SuitType SuitType { get; private set; }
    }
}
